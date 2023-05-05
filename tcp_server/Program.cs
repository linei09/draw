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
                int port = 6903;
                IPAddress ipadd = IPAddress.Parse("172.0.0.1");
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
        public static void HandleClient(object obj)
        {
            TcpClient client = (TcpClient)obj;
            NetworkStream stream = client.GetStream();
            byte[] data = new byte[1024];
            string rcv;
            while (true)
            {
                
                stream.Read(data, 0, data.Length);
                rcv = Encoding.ASCII.GetString(data);
                //
                //  if(rcv==?)
                // {
                // thực hiện yêu cầu
                // có thể là gửi tọa độ, các yêu cầu vẽ khác
                //  }
                foreach (TcpClient otherClient in clients)
                {
                    if (otherClient != client)
                    {
                        NetworkStream otherStream = otherClient.GetStream();
                        byte[] sendData = Encoding.ASCII.GetBytes(rcv);
                        otherStream.Write(sendData, 0, sendData.Length);
                        Console.WriteLine("Sent: {0}", data); // send gì do mình á
                    }
                }
                

            }
            client.Close();
            clients.Remove(client);
        }

       

       
    }


}


