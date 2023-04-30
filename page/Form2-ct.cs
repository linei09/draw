using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
namespace WindowsFormsApp1
{
    public partial class Form2_ct : Form
    {
        Stack<PictureBox> pictureBoxStack = new Stack<PictureBox>();
      
        public Form2_ct()
        {
            InitializeComponent();
            pictureBoxStack.Push(pictureBox1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //pictureBox1.Visible = false;
            //Stack<PictureBox> p = new Stack<PictureBox>();
            PictureBox p1 = new PictureBox();
            PictureBox p2 = new PictureBox();
            p2 = pictureBoxStack.Peek();
            p2.Visible = false;
            p1.Width = 100;
            p1.Height = 100;
            this.Controls.Add(p1);
            pictureBoxStack.Push(p1);
           // p1.Visible = true;
            //PIXC = p;

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            PictureBox p2 = new PictureBox();
            p2 = pictureBoxStack.Pop();
            p2.Visible=true;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            Size size = this.ClientSize;
            int width = size.Width;
            int height = size.Height;
            // chinh them label,picturebox...
        }
    }
}
