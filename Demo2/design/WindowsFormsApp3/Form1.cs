using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public partial class Form1 : Form
    {
        Stack<PictureBox> pictureBoxStack = new Stack<PictureBox>();

        private Rectangle? currentRectangle = null;
        private Rectangle? currentEllipse = null;
        public Form1()
        {
            InitializeComponent();

            pictureBoxStack.Push(pictureBox1);
            bm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            pictureBox1.Image = bm;
        }

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
        Color new_color;
        int index, x, y, cX, cY, sX, sY;

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
            //paint
            paint = true;
            py = e.Location;

            //polygons
            cX = e.X;
            cY = e.Y;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint)
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
                if (index == 11)
                {
                    currentRectangle = new Rectangle(cX, cY, sX, sY);
                    pictureBox1.Invalidate();
                }

            }

            pictureBox1.Refresh();
            //polygons
            x = e.X; y = e.Y;
            sX = e.X - cX;
            sY = e.Y - cY;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {

            paint = false;

            sX = e.X - cX;
            sY = e.Y - cY;
            //double size = 100.00;

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

        private void Undo_Click(object sender, EventArgs e)
        {
            
        }

        private void Redo_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e) //backapge
        {
            if (pictureBoxStack.Count > 0)
            {
                PictureBox p1 = new PictureBox();
                PictureBox p2 = pictureBoxStack.Peek(); // Lấy PictureBox đang hiển thị từ đỉnh của Stack
                p2.Visible = false;
                p1.Width = 100;
                p1.Height = 100;
                p1.Image = p2.Image; // Gán hình ảnh của PictureBox trên đỉnh Stack cho PictureBox mới
                this.Controls.Add(p1);
                pictureBoxStack.Push(p1);
            }
        }

        private void nextpage_Click(object sender, EventArgs e)
        {
            if (pictureBoxStack.Count > 1) // Kiểm tra nếu có ít nhất 2 PictureBox trong Stack mới lấy ra
            {
                PictureBox p2 = pictureBoxStack.Pop(); // Lấy PictureBox trên đỉnh Stack ra khỏi Stack
                p2.Visible = false;
                PictureBox p1 = pictureBoxStack.Peek();
                p1.Visible = true;
            
            }
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

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void size_pen_3_Click(object sender, EventArgs e)
        {
            index = 6;
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
    }
}
