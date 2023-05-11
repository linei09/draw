using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace WindowsFormsApp3
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        //string user = Form2.Instance.user;
        //DateTime birth = Form2.Instance.birth;


        public Form4(string user, DateTime birth)
        {
            InitializeComponent();

            // Store the user and birth values in private fields
        //    this.user = user;
        //    this.birth = birth;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //string pass = new_pass.Text;
            //if (pass != confirm.Text)
            //{
            //    label4.Visible = true;
            //}
            //else
            //{
            //    using (SqlConnection con = new SqlConnection("Data Source=MSI;Initial Catalog=MyDB;Integrated Security=True;Pooling=False"))//nay` cau bao day t cop qua{){
            //    {
            //        con.Open();
            //        SqlCommand command = new SqlCommand("UPDATE UserTable SET password=@newPassword WHERE user=@user AND birth=@");
            //        command.Parameters.AddWithValue("@user", user);
            //        command.Parameters.AddWithValue("@birth", birth);
            //        command.Parameters.AddWithValue("@newPassword",pass );
            //        command.ExecuteNonQuery();

            //    }
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
        //    this.Hide();
        //    Login lg = new Login();
        //    lg.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '\0';
            pictureBox2.Visible = false;
            pictureBox3.Visible = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
                textBox2.PasswordChar = '*';
                pictureBox3.Visible = false;
                pictureBox2.Visible = true;
            

        }
    }
}

