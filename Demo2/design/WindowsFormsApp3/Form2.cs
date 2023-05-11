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
using WindowsFormsApp3;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {

        public static Form2 Instance;
        public string user;
        public DateTime birth;
        public Form2()
        {
            InitializeComponent();
            Instance = this;
        }

       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void forgot_next_Click(object sender, EventArgs e)
        {

            user = forgot_user.Text;
            birth = dateTimePicker1.Value;

            SqlConnection con = new SqlConnection("Data Source=MSI;Initial Catalog=MyDB;Integrated Security=True;Pooling=False");//nay` cau bao day t cop qua
            con.Open();
            SqlCommand command = new SqlCommand("\"SELECT * FROM UserTable WHERE user=@user AND birth=@birth", con);
            command.Parameters.AddWithValue("@user", user);
            command.Parameters.AddWithValue("@birth", birth);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                
                if (reader.HasRows)
                {
                    this.Hide();
                    Form4 rp = new Form4();
                    rp.Show();
                    
                }
                else
                {
                    label4.Visible = true;
                }
                
                
               
            }
            con.Close();
        }

        private void forgot_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lg = new Login();
            lg.Show();
        }
    }
}
