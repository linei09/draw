using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Data.SqlClient;
using System.Security.Cryptography;
using MySql.Data.MySqlClient;

namespace tcp_server
{

    static class Program
    {
        static List<TcpClient> clients = new List<TcpClient>();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static int connectedClientsCount = 0;

        [STAThread]

        public static void ConvertBinaryToPng(byte[] binaryData, string outputPath)
        {
            using (MemoryStream memoryStream = new MemoryStream(binaryData))
            {
                using (Bitmap bitmap = new Bitmap(memoryStream))
                {
                    bitmap.Save(outputPath, System.Drawing.Imaging.ImageFormat.Png);
                }
            }
        }

        static void Main()
        {

            

            TcpListener server = null;
            try
            {
                int port = 8080;
                IPAddress ipadd = IPAddress.Any;
                server = new TcpListener(ipadd, port);
                server.Start();

                //TcpClient client = server.AcceptTcpClient(); // chấp nhận kết nối
                // bắt đầu
                // 

                while (true)
                {
                    Console.WriteLine("Waiting for a connection...");

                    // Chấp nhận kết nối từ Client
                    TcpClient client = server.AcceptTcpClient();
                    Console.WriteLine("Connected!");
                    if( client.Connected) connectedClientsCount++;
                    clients.Add(client);
                    Console.WriteLine(connectedClientsCount.ToString());
                    foreach (TcpClient otherClient in clients)
                    {
                        if (otherClient != client)
                        {
                            NetworkStream otherStream = otherClient.GetStream();
                            byte[] sendData = new byte[1024];
                            sendData = Encoding.ASCII.GetBytes("update");

                            otherStream.Write(sendData, 0, sendData.Length);
                            otherStream.Flush();

                        }
                    }

                    // Khởi tạo một luồng để xử lý kết nối từ Client
                    Thread t = new Thread(new ParameterizedThreadStart(HandleClient));
                    t.Start(client);
                    if(connectedClientsCount == 0)
                    {
                        Console.WriteLine("No more client");
                    }
                   

                }
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);
            }
            finally
            {
                // Ngừng lắng nghe các kết nối từ Client
                server.Stop();
            }

           

        }
        private static readonly List<int> sections = new List<int>();

        private static string numberPart;
        private static string base64Part;
        private static byte[] temp;
        public static void HandleClient(object obj)
        {
            TcpClient client = (TcpClient)obj;
            NetworkStream stream = client.GetStream();
            byte[] data = new byte[1024];
            string rcv;
            int bytesRead = 0;

            try
            {
                while ((bytesRead = stream.Read(data, 0, data.Length)) > 0)
                {

                    
                    rcv = Encoding.ASCII.GetString(data);
                    rcv = rcv.TrimEnd('\0');
                    Console.WriteLine(rcv);

                    //if (rcv == "New")
                    //{
                    //    Random random = new Random();   
                    //    int section = random.Next(1,1000);
                    //    sections.Add(section);
                    //    Console.WriteLine("Received section value: " + section);
                    //    // send về client section
                    //    byte[] sectiondata=Encoding.ASCII.GetBytes(section.ToString());
                       
                    //    stream.Write(sectiondata, 0, sectiondata.Length);
                    //    using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-8M2NJ75;Initial Catalog=TestMang;Integrated Security=True"))
                    //    {
                    //        connection.Open();

                    //        string query = "insert into drawings(mane) value(@id)";
                    //        using (SqlCommand command = new SqlCommand(query, connection))
                    //        {
                    //            command.Parameters.AddWithValue("@id", numberPart);
                    //            using (SqlDataReader reader = command.ExecuteReader())
                    //            {
                    //                reader.Read();
                    //            }
                    //        }
                    //    }


                    //}

                    //if (char.IsDigit(rcv[0]))
                    //{
                    //    int spaceIndex = rcv.IndexOf(' ');
                    //    if (spaceIndex >= 0)
                    //    {
                    //        numberPart = rcv.Substring(0, spaceIndex);
                    //        base64Part = rcv.Substring(spaceIndex + 1);
                            
                    //        temp = Convert.FromBase64String(base64Part);
                    //        string server = "localhost";
                    //        string database = "drawings";
                    //        string username = "root";
                    //        string password = "";
                    //        string constring = $"SERVER={server};DATABASE={database};UserId={username};PASSWORD={password}";
                    //        MySqlConnection conn = new MySqlConnection(constring);
                    //        conn.Open();
                    //        string query = "update draw set data = @data where name = @id ";
                    //        MySqlCommand cmd = new MySqlCommand(query, conn);
                    //        cmd.CommandType = CommandType.Text;
                    //        cmd.Parameters.AddWithValue("@id", numberPart);
                    //        cmd.Parameters.AddWithValue("data", temp);
                    //        MySqlDataReader reader = cmd.ExecuteReader();
                    //        while (reader.Read())
                    //        {
                    //            //Console.WriteLine(reader["name"]);
                    //        }
                    //    }
                    //}

                    if (!client.Connected)
                    {
                        Console.WriteLine(connectedClientsCount.ToString());
                        break;
                    }


                    //Console.WriteLine(rcv);

                    foreach (TcpClient otherClient in clients)
                    {
                        if (otherClient != client)
                        {
                            NetworkStream otherStream = otherClient.GetStream();
                            byte[] sendData = new byte[1024];
                            sendData = Encoding.ASCII.GetBytes(rcv);

                            otherStream.Write(sendData, 0, sendData.Length);
                            otherStream.Flush();

                        }
                    }


                }

            }
            catch (IOException ex)
            {
                Console.WriteLine("IOException: {0}", ex);
                if (ex.Message.Contains("An existing connection was forcibly closed by the remote host"))
                {
                    connectedClientsCount--;
                    Console.WriteLine(connectedClientsCount);
                    
                }
            }
            finally
            {
                client.Close();
                clients.Remove(client);
                connectedClientsCount--;
                if (clients.Count == 0)
                {
                    Console.WriteLine("last client disconected, saving file");

                   
                    //string server = "localhost";
                    //string database = "drawings";
                    //string username = "root";
                    //string password = "";
                    //string constring = $"SERVER={server};DATABASE={database};UserId={username};PASSWORD={password}";
                    //MySqlConnection conn = new MySqlConnection(constring);
                    //conn.Open();
                    //string query = "update draw set data = @data where name = @id ";
                    //MySqlCommand cmd = new MySqlCommand(query, conn);
                    //cmd.CommandType = CommandType.Text;
                    //cmd.Parameters.AddWithValue("@id", numberPart);
                    //cmd.Parameters.AddWithValue("data", temp);
                    //MySqlDataReader reader = cmd.ExecuteReader();
                    //while (reader.Read())
                    //{
                    //    //Console.WriteLine(reader["name"]);
                    //}
                }


            }
        }
        

    }

}


