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
        public Form1()
        {
            InitializeComponent();
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

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

        private void Pen_Click(object sender, EventArgs e)
        {

        }
    }
}
