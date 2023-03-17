using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.Odbc;
using System.Net.NetworkInformation;
using System.Drawing.Imaging;
using System.Xml.Linq;

using PdfSharp.Drawing;
using PdfSharp.Pdf;
using Aspose.Pdf.Devices;


namespace import_picture_test
{
    public partial class Form1 : Form
    {

        Bitmap bm;
        Graphics g;
        bool paint = false;
        Point  px,py;
        Pen p = new Pen(Color.Black,1);
        Pen Erraser = new Pen (Color.White,20);
        int index;
        int control;
        int x,y,sx,sy,cx,cy;



        public Form1()
        {
            InitializeComponent();
            Rectangle rectangle = Screen.PrimaryScreen.Bounds;
            bm = new Bitmap(rectangle.Width, rectangle.Height);
           
            g = Graphics.FromImage(bm);
            g.DrawImage(bm,0,0);    
            g.Clear(Color.White);
            
            pictureBox1.Image = bm;
            button2.Enabled = false;
            button3.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select image";
            ofd.Filter = "Image File (*.jpg; *.jpeg; )|*.jpg; *.jpeg;"; //*|PDF File (*.pdf;)|*.pdf; */  // pdf needs to be converted first

            if (ofd.ShowDialog() == DialogResult.OK)
            {

                Bitmap image1 = new Bitmap(ofd.FileName);
                g = Graphics.FromImage(image1);

                pictureBox1.Image = image1;

                button3.Enabled = true;
                button2.Enabled = true;
               
            }
                    
        }

        public static void ConvertPDFtoJpeg(string Filename)
        {

            

        }
        

        private void button2_Click(object sender, EventArgs e)
        {
           
            pictureBox1.CancelAsync();
            pictureBox1.Image.Dispose();
            pictureBox1.Image = null;
            button2.Enabled = false;
            button3.Enabled = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog ofd = new SaveFileDialog();
            ofd.Title = "Save image";
            ofd.Filter = "Save file (*.jpg; *.jpeg; *.pdf;)|*.jpg; *.jpeg; *.pdf|Pdf file(*.pdf;)|*.pdf;";//chua co pdf 
            if (ofd.ShowDialog() == DialogResult.OK)
            {
               pictureBox1.Image.Save(ofd.FileName);
            }
           
        }

      
        private void BtnColor_Click(object sender, EventArgs e)
        {

        }

     

        private void BtnPencil_Click(object sender, EventArgs e)
        {
            control = 1;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                paint = true;
                py = e.Location;
                cx = e.X;
                cy = e.Y;
            }
        }
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                px = e.Location;
                paint = false;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint)
            {
                if (control == 1)
                {
                    px = e.Location;
                    g.DrawLine(p, px, py);
                    py = px;
                }
                if (control == 2)
                {
                    px = e.Location;
                    g.DrawLine(Erraser, px, py);
                    py = px;
                }
            }
            pictureBox1.Refresh();

        }

        private void BtnEraser_Click(object sender, EventArgs e)
        {
            control = 2;
        }

        private void BtnEllipse_Click(object sender, EventArgs e)
        {

        }

        

       

       
    }
}
