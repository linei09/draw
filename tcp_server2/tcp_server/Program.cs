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

namespace tcp_server
{

    static class Program
    {
        static List<TcpClient> clients = new List<TcpClient>();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        
        [STAThread]
        static void Main()
        {

            
            TcpListener server = null;
            try
            {
                int port = 8080;
                IPAddress ipadd = IPAddress.Parse("127.0.0.1");
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
                    clients.Add(client);
                    // Khởi tạo một luồng để xử lý kết nối từ Client
                    Thread t = new Thread(new ParameterizedThreadStart(HandleClient));
                    t.Start(client);
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

                    if (rcv == "New")
                    {
                        Random random = new Random();   
                        int section = random.Next(1,1000);
                        sections.Add(section);
                        Console.WriteLine("Received section value: " + section);
                        // send về client section
                        byte[] sectiondata=Encoding.ASCII.GetBytes(section.ToString());
                        stream.Write(sectiondata, 0, sectiondata.Length);

                    }
                        
                    Console.WriteLine(rcv);

                    foreach (TcpClient otherClient in clients)
                    {
                        if (otherClient != client)
                        {
                            NetworkStream otherStream = otherClient.GetStream();
                            byte[] sendData = new byte[1024];
                            sendData = Encoding.ASCII.GetBytes(rcv);

                            otherStream.Write(sendData, 0, sendData.Length);

                        }
                    }


                }

            }
            catch (IOException ex)
            {
                Console.WriteLine("IOException: {0}", ex);
            }
            finally
            {
                client.Close();
                clients.Remove(client);
            }
        }
    }




}


