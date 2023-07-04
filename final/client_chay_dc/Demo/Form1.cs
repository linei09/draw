using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Threading;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices.ComTypes;
using System.Web;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Net;
using System.Data.SqlClient;
using System.Drawing.Imaging;
using System.CodeDom;
using static System.Collections.Specialized.BitVector32;
using MySql.Data.MySqlClient;
using System.Collections;


namespace Demo
{
    public partial class Form1 : Form
    {
        private Rectangle? currentRectangle = null;
        private Rectangle? currentEllipse = null;

        byte[] key = Encoding.UTF8.GetBytes("0399865420A@YH2D"); // 16-byte key for AES 128


        public Form1()
        {
            InitializeComponent();

            bm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            pictureBox1.Image = bm;

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            p1.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            p1.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            p2.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            p2.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            p3.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            p3.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            eraser1.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            eraser1.EndCap = System.Drawing.Drawing2D.LineCap.Round;


            eraser2.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            eraser2.EndCap = System.Drawing.Drawing2D.LineCap.Round;


            eraser3.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            eraser3.EndCap = System.Drawing.Drawing2D.LineCap.Round;

        }
        int sectionValue;
        TcpClient client = null;
        NetworkStream stream;
        byte[] data = new byte[1024];
        Bitmap bm;
        Graphics g;
        bool paint = false;
        Point px, py;
        Pen p1 = new Pen(Color.Black, 1);
        Pen p2 = new Pen(Color.Black, 5);
        Pen p3 = new Pen(Color.Black, 10);
        Pen eraser1 = new Pen(Color.White,10);
        Pen eraser2 = new Pen(Color.White,30);
        Pen eraser3 = new Pen(Color.White,50);
        ColorDialog cd = new ColorDialog();
        Color new_color = Color.Black;
        int index,x,y,cX,cY,sX,sY;


        private CancellationTokenSource cancellationTokenSource;
        private CancellationToken cancellationToken;

        public static byte[] EncryptMessage(string message, byte[] key)
        {
            byte[] encryptedBytes;

            using (AesManaged aes = new AesManaged())
            {
                aes.Key = key;
                aes.Mode = CipherMode.ECB;
                aes.Padding = PaddingMode.PKCS7;

                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                    {
                        byte[] plainBytes = Encoding.UTF8.GetBytes(message);
                        cryptoStream.Write(plainBytes, 0, plainBytes.Length);
                        cryptoStream.FlushFinalBlock();
                        encryptedBytes = memoryStream.ToArray();
                    }
                }
            }

            return encryptedBytes;
        }

        public static string DecryptMessage(byte[] encryptedBytes, byte[] key)
        {
            string decryptedMessage;

            using (AesManaged aes = new AesManaged())
            {
                aes.Key = key;
                aes.Mode = CipherMode.ECB;
                aes.Padding = PaddingMode.PKCS7;

                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                using (MemoryStream memoryStream = new MemoryStream(encryptedBytes))
                {
                    using (CryptoStream cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader streamReader = new StreamReader(cryptoStream))
                        {
                            decryptedMessage = streamReader.ReadToEnd();
                        }
                    }
                }
            }

            return decryptedMessage;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            //openFileDialog.Filter = "PNG (*.png) | *.png |PDF(*.pdf) | *.pdf | All files(*.*) | *.* ";
            if(openFileDialog.ShowDialog()==DialogResult.OK)
            {
                pictureBox1.Image=Image.FromFile(openFileDialog.FileName);
            }
           
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Save";
            saveFileDialog.ShowDialog();
            
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog_SaveAs = new SaveFileDialog();
            saveFileDialog_SaveAs.ShowDialog();
        }


        // ham nhan de xu ly command
        private void Form1_Load(object sender, EventArgs e)
        {
            // lấy data từ db về dc thì nhớ fix
           

            int port = 8080;
            IPAddress ipadd = IPAddress.Parse("127.0.0.1");

            // Connect to the server
            client = new TcpClient();
            client.Connect(ipadd, port);



            //LoadDrawing();

            CheckForIllegalCrossThreadCalls = false;
            cancellationTokenSource = new CancellationTokenSource();
            cancellationToken = cancellationTokenSource.Token;
            Task.Run(() => ReceiveData(cancellationToken));

            NetworkStream stream = client.GetStream();

            // Send a request to the server for a new section
            //byte[] requestData = Encoding.ASCII.GetBytes("New");
            //stream.Write(requestData, 0, requestData.Length);


        }

        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Exit = MessageBox.Show("Want to close the program?","Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(Exit == DialogResult.Yes) { Close(); }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void Eraser_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void Eraser_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void Eraser_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void Eraser_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void Eraser_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            py = e.Location;

            cX = e.X;
            cY = e.Y;
           
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint)
            {
                (Point,Point) p = Paint(index, e);
                Point x = p.Item1;
                Point y = p.Item2;

                try
                {
                    string command = null;

                    //    JObject command = new JObject();
                    if (index > 0 && index <= 6)
                    {
                        command = $"draw_line {x.X} {x.Y} {y.X} {y.Y}";
                        command += $" {new_color.ToArgb()}";
                        command += $" {index}\n";

                        string[] commandParts = command.Split(' ');
                        for (int i = 0; i < 10; i++)
                        {
                            if (commandParts.Length == 7)
                            {
                                break;
                            }
                            else {
                                command = $"draw_line {x.X} {x.Y} {y.X} {y.Y}";
                                command += $" {new_color.ToArgb()}";
                                command += $" {index}\n";
                            }
                        }
                           


                        NetworkStream ns = client.GetStream();
                        byte[] sendData = new byte[1024];

                        
                        

                        byte[] encryptedBytes = EncryptMessage(command, key);
                        string encryptedText = Convert.ToBase64String(encryptedBytes);

                        sendData = Encoding.ASCII.GetBytes(encryptedText);
                        ns.Write(sendData, 0, sendData.Length);
                    }
                   
                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
               
            }
            
                x = e.X; y = e.Y;
                sX = e.X - cX;
                sY = e.Y - cY;
                pictureBox1.Refresh();
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
             
                paint = false;
                sX = e.X - cX;
                sY = e.Y - cY;

            string command = null;

            if (index == 10)
            {
                g.DrawEllipse(p1, cX, cY, sX, sY);
                currentEllipse = null;
                command = $"draw_ellipse {cX} {cY} {sX} {sY}";
                command += $" {new_color.ToArgb()}";
                command += $" {index}";
            }
            
            if (index == 11)
            {
                g.DrawRectangle(p1, cX, cY, sX, sY);
                currentRectangle = null;
                command = $"draw_rec {cX} {cY} {sX} {sY}";
                command += $" {new_color.ToArgb()}";
                command += $" {index}";

            }

            if (command != null)
            {
                string[] commandParts = command.Split(' ');
                for (int i = 0; i < 10; i++)
                {
                    if (commandParts.Length == 7)
                    {
                        break;
                    }
                    if (index == 10)
                    {

                        command = $"draw_ellipse {cX} {cY} {sX} {sY}";
                    }
                    else if (index == 11)
                    {

                        command = $"draw_rec {cX} {cY} {sX} {sY}";

                    }
                    command += $" {new_color.ToArgb()}";
                    command += $" {index}\n";
                }

                Console.WriteLine(command);
                NetworkStream ns = client.GetStream();
                byte[] sendData = new byte[1024];

                byte[] encryptedBytes = EncryptMessage(command, key);
                string encryptedText = Convert.ToBase64String(encryptedBytes);

                sendData = Encoding.ASCII.GetBytes(encryptedText);
              
                ns.Write(sendData, 0, sendData.Length);
                ns.Flush();

            }
            pictureBox1.Refresh();

        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void back_eraser_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        private void size_eraser_1_Click(object sender, EventArgs e)
        {
            index = 1;
        }

        private void size_eraser_2_Click(object sender, EventArgs e)
        {
            index = 2;
        }

        private void size_eraser_3_Click(object sender, EventArgs e)
        {
            index = 3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
        }

        private void Polygons_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
        }

        private void _circle_Click(object sender, EventArgs e)
        {
            index = 10;
        }

        private void back_pen_Click(object sender, EventArgs e)
        {
            panel5.Visible = false;
        }

        private void _retangle_Click(object sender, EventArgs e)
        {
            index = 11;
        }

        private void _polygons_Click(object sender, EventArgs e)
        {
            index = 12;
        }

        private void size_pen_1_Click(object sender, EventArgs e)
        {
            index = 4;
        }

        private void size_pen_2_Click(object sender, EventArgs e)
        {
            index = 5;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (currentRectangle.HasValue)
            {
                e.Graphics.DrawRectangle(p1, currentRectangle.Value);
            }

            if (currentEllipse.HasValue)
            {
                e.Graphics.DrawEllipse(p1, currentEllipse.Value);
            }
        }

        private void size_pen_3_Click(object sender, EventArgs e)
        {
            index = 6;
        }

        private void Process_command(string command_draw)
        {
            
            string control = command_draw;
            int newlineIndex = control.IndexOf('\n');
            if (newlineIndex != -1)
            {
                string trimmed = control.Substring(0, newlineIndex);
                control = trimmed;
            }
       


            string[] commandParts = command_draw.Split(' ');
            if (commandParts.Length != 7)
            {
                MessageBox.Show("Invalid command format!");
                return;
            }
           

            int x1 = 0, y1 = 0, x2 = 0, y2 = 0,color = 0,index = 0;

            bool parseSuccess = int.TryParse(commandParts[1], out x1)
                && int.TryParse(commandParts[2], out y1)
                && int.TryParse(commandParts[3], out x2)
                && int.TryParse(commandParts[4], out y2)
                && int.TryParse(commandParts[5], out color)
                && int.TryParse(commandParts[6], out index);

            if (!parseSuccess)
            {
                return;
            }

            PaintFromCommand(index, x1, y1, x2, y2, color);

            
            
            //JObject obj = JObject.Parse(control);


            //string command = (string)obj["command"];

            //if (command == "draw_line")
            //{
            //    int x1 = (int)obj["x1"];
            //    int y1 = (int)obj["y1"];
            //    int x2 = (int)obj["x2"];
            //    int y2 = (int)obj["y2"];
            //    int color = (int)obj["color"];
            //    int index = (int)obj["index"];

            //    Paint(index, x1, y1, x2, y2,color);
            //}
            //else if ( command == "draw_ellipse" || command == "draw_rec")
            //{
            //    int x1 = (int)obj["cX"];
            //    int y1 = (int)obj["cY"];
            //    int x2 = (int)obj["sX"];
            //    int y2 = (int)obj["sY"];
            //    int color = (int)obj["color"];
            //    int index = (int)obj["index"];

            //    Paint(index, x1, y1, x2, y2, color);

            //}


        }

        private void back_color_Click(object sender, EventArgs e)
        {
            panel6.Visible = false;
        }

        private void _Color_Click(object sender, EventArgs e)
        {
            cd.ShowDialog();
            new_color=cd.Color;
            _Color.BackColor = cd.Color;
            p1.Color = cd.Color;
            p2.Color = cd.Color;
            p3.Color = cd.Color;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }


        byte[] imageData = null;
        

        //private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    cancellationTokenSource.Cancel();
        //    using (NetworkStream ns = client.GetStream())
        //    {

        //        Image image = pictureBox1.Image;
        //        byte[] imageData = null;

        //        if (image != null)
        //        {
        //            using (MemoryStream ms = new MemoryStream())
        //            {
        //                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
        //                imageData = ms.ToArray();

        //                string base64String = Convert.ToBase64String(imageData);
                      
        //                string temp_string = sectionValue.ToString() + ' ' + base64String;
        //                byte[] temp_array = Encoding.ASCII.GetBytes(temp_string);

        //                ns.Write(temp_array, 0, temp_array.Length);
        //                ns.Flush();

                        
        //            }
        //        }
              
               
        //    }
        //}

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

        private void button1_Click_1(object sender, EventArgs e)
        {
            stream = client.GetStream();
            string id = textBox2.Text.ToString().Trim();
            string change_id = "update_id: "+id;
            Console.WriteLine(change_id);
            byte[] change_id_byte = Encoding.ASCII.GetBytes(change_id);

            stream.Write(change_id_byte,0,change_id_byte.Length);
            stream.Flush();
          
            

        }

        private void color_red_Click(object sender, EventArgs e)
        {
            index = 7;
        }
        //private void lstDrawings_SelectedValueChanged_1(object sender, EventArgs e)
        //{
        //    string id = lstDrawings.GetItemText(lstDrawings.SelectedItem);
        //    id = "id: " + id;
        //    int.TryParse(id, out sectionValue);
        //    byte[] temp = Encoding.ASCII.GetBytes(id);
        //    stream.Write(temp, 0, temp.Length);
        //    stream.Flush();
        //}

        private void color_blue_Click(object sender, EventArgs e)
        {
            index = 8;
        }

        private void color_yellow_Click(object sender, EventArgs e)
        {
            index = 9;
        }

        private void Pen_Click(object sender, EventArgs e)
        {
            panel5.Visible = true;
        }

        private async void ReceiveData(CancellationToken cancellationToken)
        {
            byte[] buffer = new byte[1024];
            int bytes;
            try
            {
                while (!cancellationToken.IsCancellationRequested)
                {
                    stream = client.GetStream();
                    bytes = await stream.ReadAsync(buffer, 0, buffer.Length);
                    stream.Flush();
                    string returnData = Encoding.ASCII.GetString(buffer, 0, bytes);
                    try
                    {
                        byte[] decryptedBytes = Convert.FromBase64String(returnData);
                        string decryptedMessage = DecryptMessage(decryptedBytes, key);
                        string[] commandParts = decryptedMessage.Split(' ');
                        if (commandParts.Length != 7)
                        {
                            continue;
                        }

                        decryptedMessage = decryptedMessage.TrimEnd('\0');

                        Console.WriteLine(decryptedMessage);

                        // Update the TextBox control on the main thread
                        textBox1.Text = decryptedMessage;
                        Process_command(decryptedMessage);

                    }
                    catch
                    {
                        int temp_section;
                        
                        bool check = int.TryParse(returnData, out temp_section);
                        if (check)
                        {
                            sectionValue = temp_section;
                            textBox3.Text = sectionValue.ToString();
                            Console.WriteLine(sectionValue);
                        }
                        else
                        {
                            if (returnData.Contains("update_data"))
                            {
                                Console.WriteLine("update " + sectionValue.ToString());
                               
                                Image image = pictureBox1.Image;
                                byte[] imageData = null;

                                if (image != null)
                                {
                                    using (MemoryStream ms = new MemoryStream())
                                    {
                                        image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                                        imageData = ms.ToArray();

                                        string base64String = Convert.ToBase64String(imageData);

                                        string temp_string = sectionValue.ToString() + ' ' + base64String;
                                        byte[] temp_array = Encoding.ASCII.GetBytes(temp_string);

                                        stream.Write(temp_array, 0, temp_array.Length);
                                        stream.Flush();
                                       


                                    }
                                }
                            }
                            //if (returnData.Contains("id_list:"))
                            //{
                            //    int spaceIndex = returnData.IndexOf(' ');
                            //    if (spaceIndex >= 0)
                            //    {
                            //        string junk = returnData.Substring(0, spaceIndex);
                            //        string id_list = returnData.Substring(spaceIndex + 1);
                            //        string[] id = id_list.Split(' ');
                            //        lstDrawings.DropDownStyle = ComboBoxStyle.DropDownList;
                            //        lstDrawings.Items.Clear();
                            //        lstDrawings.Items.AddRange(id);

                            //    }
                            //}
                            if (returnData.Contains("id:"))
                            {
                                int spaceIndex = returnData.IndexOf(' ');
                                if (spaceIndex >= 0)
                                {
                                    string junk = returnData.Substring(0, spaceIndex);
                                    string data = returnData.Substring(spaceIndex + 1);
                                    byte[]bg_data = Convert.FromBase64String(data);
                                    using (MemoryStream memoryStream = new MemoryStream(bg_data))
                                    {
                                        using (Bitmap bitmap = new Bitmap(memoryStream))
                                        {
                                            pictureBox1.Image = bitmap;
                                        }
                                    }


                                }
                            }

                            if (returnData.Contains("update_id"))
                            {
                                int spaceIndex = returnData.IndexOf(' ');
                                if (spaceIndex >= 0)
                                {
                                    string junk = returnData.Substring(0, spaceIndex);
                                    string data = returnData.Substring(spaceIndex + 1);
                                    textBox3.Text = data;


                                }
                            }
                        }


                    }
                }
                if (cancellationToken.IsCancellationRequested)
                {
                    return;
                }
            }
            catch
            {

            }
           
        }


        private (Point,Point)  Paint( int index, MouseEventArgs e)
        {
            Point temp_p = new Point(0,0);
            (Point, Point) paint_point = (temp_p,temp_p)  ;
            if (index == 1)
            {
                px = e.Location;
                g.DrawLine(eraser1, px, py);
                paint_point = (px, py);
                py = px;
            }
            if (index == 2)
            {
                px = e.Location;
                g.DrawLine(eraser2, px, py);
                paint_point = (px, py);
                py = px;
            }
            if (index == 3)
            {
                px = e.Location;
                g.DrawLine(eraser3, px, py);
                paint_point = (px, py);
                py = px;
            }
            if (index == 4)
            {
                px = e.Location;
                g.DrawLine(p1, px, py);
                paint_point = (px, py);
                py = px;
            }
            if (index == 5)
            {
                px = e.Location;
                g.DrawLine(p2, px, py);
                paint_point = (px, py);
                py = px;
            }
            if (index == 6)
            {
                px = e.Location;
                g.DrawLine(p3, px, py);
                paint_point = (px, py);
                py = px;
            }
            if (index == 10)
            {
                currentEllipse = new Rectangle(cX, cY, sX, sY);
                pictureBox1.Invalidate();
            }
            else if (index == 11)
            {
                currentRectangle = new Rectangle(cX, cY, sX, sY);
                pictureBox1.Invalidate();
            }

            return paint_point;
            
        }


        private void PaintFromCommand(int index, int x1, int y1, int x2, int y2,int color )
        {
            Point px = new Point(x1, y1);
            Point py = new Point(x2, y2);
            Color Color1 = Color.FromArgb(color);

            p1.Color = Color1;
            p2.Color = Color1;
            p3.Color = Color1;

            if (index == 2)
            {
                g.DrawLine(eraser2, px, py);
                py = px;
            }
            if (index == 3)
            {
                g.DrawLine(eraser3, px, py);
                py = px;
            }
            if (index == 4)
            {
                g.DrawLine(p1, px, py);
                py = px;
            }
            if (index == 5)
            {
                g.DrawLine(p2, px, py);
                py = px;
            }
            if (index == 6)
            {
                g.DrawLine(p3, px, py);
                py = px;
            }
            if (index == 10)
            {
                currentEllipse = new Rectangle(x1, y1, x2, y2);
                g.DrawEllipse(p1, currentEllipse.Value);
                pictureBox1.Invalidate();
            }
            else if (index == 11)
            {
                currentRectangle = new Rectangle(x1, y1, x2, y2);
                g.DrawRectangle(p1, currentRectangle.Value);
                pictureBox1.Invalidate();
            }
        }

        //private void LoadDrawing()
        //{
        //    // đổi lại connection
        //    stream = client.GetStream();
        //    string temp = "get id\n";
        //    byte[] temp2 = Encoding.ASCII.GetBytes(temp);
        //    stream.Write(temp2,0,temp2.Length);
        //    stream.Flush();

          
        //}

    }
}



