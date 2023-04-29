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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ComboBox = System.Windows.Forms.ComboBox;

namespace Demo
{
    public partial class Form1 : Form
    {
        Bitmap bm;
        Graphics g;
        bool paint = false;
        Point px, py;
        Pen p = new Pen(Color.Black,1);
        Pen Erraser = new Pen(Color.White, 20);
        int index;
        int control;
        int x, y, sx, sy, cx, cy;


        Color clr;
        ColorDialog cd = new ColorDialog();


        public Form1()
        {
            InitializeComponent();

            Rectangle rectangle = Screen.PrimaryScreen.Bounds;
            bm = new Bitmap(rectangle.Width, rectangle.Height);

            g = panel1.CreateGraphics();
            g.DrawImage(bm, 0, 0);
            g.Clear(Color.White);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            p.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            p.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            

            List<string> pen_size;
            pen_size = new List<string>() { "Small", "Medium", "Large" };
            comboBox1.DataSource = pen_size;

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            //openFileDialog.Filter = "PNG (*.png) | *.png |PDF(*.pdf) | *.pdf | All files(*.*) | *.* ";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
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



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

      

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Exit = MessageBox.Show("Want to close the program?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Exit == DialogResult.Yes) { Close(); }
        }

        private void pen_config_colors_Click(object sender, EventArgs e)
        {
            cd.ShowDialog();
            clr = cd.Color;
            p.Color = clr;

        }

        
      

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            
            ComboBox cb = sender as ComboBox;
            if( cb.SelectedItem.ToString() == "Small"){
                p.Width = 1;
                
            }
            if (cb.SelectedItem.ToString() == "Medium")
            {
                p.Width = 15;
               
            }
            if (cb.SelectedItem.ToString() == "Large")
            {
                p.Width = 25;
            }
            


        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                paint = true;
                py = e.Location;
                cx = e.X;
                cy = e.Y;
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
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
            
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                px = e.Location;
                paint = false;
            }
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            g = Graphics.FromImage(bm);
            pictureBox1.Image = bm;
            g.DrawImage(bm, 0, 0);
            
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            g = panel1.CreateGraphics();
           
      
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {

        }

       

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void Pen_Click(object sender, EventArgs e)
        {
            control = 1;
            pen_config.Visible = true;
            panel2.Visible = false;
        }
        private void pen_config_return_Click(object sender, EventArgs e)
        {
            pen_config.Visible = false;
            panel2.Visible = true;
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
    }
}
