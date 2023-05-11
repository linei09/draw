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

namespace Demo
{
    public partial class Form1 : Form
    {
        private Rectangle? currentRectangle = null;
        private Rectangle? currentEllipse = null;

        
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
        TcpClient client;
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
            client = new TcpClient("127.0.0.1", 6903);
            stream = client.GetStream();

            Thread t = new Thread(new ThreadStart(ReceiveData));
            t.Start();
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
                Paint(index, e);

                try
                {
                    JObject command = new JObject();
                    if( index > 0 && index < 6)
                    {
                        command["command"] = "draw_line";
                        command["x1"] = px.X;
                        command["y1"] = px.Y;
                        command["x2"] = py.X;
                        command["y2"] = py.Y;
                    }
                    else if( index == 10)
                    {
                        command["command"] = "draw_ellipse";
                        command["cX"] = cX;
                        command["cY"] = cY;
                        command["sX"] = sX;
                        command["sY"] = sY;
                    }
                    else if (index == 11)
                    {
                        command["command"] = "draw_rec";
                        command["cX"] = cX;
                        command["cY"] = cY;
                        command["sX"] = sX;
                        command["sY"] = sY;
                    }
                    command["color"] = new_color.ToArgb();
                    command["index"] = index.ToString();

                    //gui command di cho server
                        
                    TcpClient client = new TcpClient();
                    client.Connect("127.0.0.1", 6903);


                    StreamWriter writer = new StreamWriter(client.GetStream());


                    string commandString = command.ToString();
                    writer.WriteLine(commandString);
                    writer.Flush();

                    writer.Close();


                    textBox1.Text = commandString;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
               



            }
            pictureBox1.Refresh();
                x = e.X; y = e.Y;
                sX = e.X - cX;
                sY = e.Y - cY;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
             
                paint = false;
                sX = e.X - cX;
                sY = e.Y - cY;

            if (index == 10)
            {
                g.DrawEllipse(p1, cX, cY, sX, sY);
                currentEllipse = null;
            }
            else if (index == 11)
            {
                g.DrawRectangle(p1, cX, cY, sX, sY);
                currentRectangle = null;

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
            JObject obj = JObject.Parse(control);


            string command = (string)obj["command"];

            if (command == "draw_line")
            {
                int x1 = (int)obj["x1"];
                int y1 = (int)obj["y1"];
                int x2 = (int)obj["x2"];
                int y2 = (int)obj["y2"];
                int color = (int)obj["color"];
                int index = (int)obj["index"];

                Paint(index, x1, y1, x2, y2,color);
            }
            else if ( command == "draw_ellipse" || command == "draw_rec")
            {
                int x1 = (int)obj["cX"];
                int y1 = (int)obj["cY"];
                int x2 = (int)obj["sX"];
                int y2 = (int)obj["sY"];
                int color = (int)obj["color"];
                int index = (int)obj["index"];

                Paint(index, x1, y1, x2, y2, color);

            }
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

        private void color_red_Click(object sender, EventArgs e)
        {
            index = 7;
        }

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

        private void ReceiveData()
        {
            while (true)
            {
                int bytesRead = stream.Read(data, 0, data.Length);
                string message = Encoding.ASCII.GetString(data, 0, bytesRead);

                // Update the TextBox control on the main thread
                Process_command(message);


            }
        }


        private void Paint( int index, MouseEventArgs e)
        {
            if (index == 1)
            {
                px = e.Location;
                g.DrawLine(eraser1, px, py);
                py = px;
            }
            if (index == 2)
            {
                px = e.Location;
                g.DrawLine(eraser2, px, py);
                py = px;
            }
            if (index == 3)
            {
                px = e.Location;
                g.DrawLine(eraser3, px, py);
                py = px;
            }
            if (index == 4)
            {
                px = e.Location;
                g.DrawLine(p1, px, py);
                py = px;
            }
            if (index == 5)
            {
                px = e.Location;
                g.DrawLine(p2, px, py);
                py = px;
            }
            if (index == 6)
            {
                px = e.Location;
                g.DrawLine(p3, px, py);
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
        }


        private void Paint(int index, int x1, int y1, int x2, int y2,int color )
        {
            Point px = new Point(x1, y1);
            Point py = new Point(x2, y2);
            Color Color1 = Color.FromArgb(color);

            p1.Color = Color1;
            p2.Color = Color1;
            p3.Color = Color1;

            //switch  (index)
            //{
            //    case 1:
            //        g.DrawLine(eraser1, px, py);
            //        py = px;
            //        break;
            //    case 2:
            //        g.DrawLine(eraser2, px, py);
            //        py = px;
            //        break;
            //    case 3:
            //        g.DrawLine(p1, px, py);
            //        py = px;
            //        break;
            //    case 4:
            //        g.DrawLine(p1, px, py);
            //        py = px;
            //        break;
            //    case 5:
            //        g.DrawLine(p2, px, py);
            //        py = px;
            //        break;
            //    case 6:
            //        g.DrawLine(p3, px, py);
            //        py = px;
            //        break;
            //    default:
            //        break
            //}


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
                pictureBox1.Invalidate();
            }
            else if (index == 11)
            {
                currentRectangle = new Rectangle(x1, y1, x2, y2);
                pictureBox1.Invalidate();
            }
        }

    }
}
