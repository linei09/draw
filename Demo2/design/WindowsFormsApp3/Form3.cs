using Demo;
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

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=MSI;Initial Catalog=MyDB;Integrated Security=True;Pooling=False");

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }


        private void forgot_Click(object sender, EventArgs e)
        {
            if (forgot.Text == "Forgot password?")
            {

            }
        }
        private bool isValid()
        {
            if(text_user.Text==string.Empty || text_pass.Text==string.Empty)
            
                MessageBox.Show("Please enter user or password!","Error");
            
            return true;
        }


        private void signin_Click(object sender, EventArgs e)
        {
            if (signin.Text == "Sign in")
            {
                this.Hide();
                Form1 lg = new Form1();
                lg.Show();
            }

            /*if(isValid())
            {
                string querry = "SELECT * FROM UserTable WHERE User = '" + text_user.Text + "' AND Password = '" + text_pass.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry,conn);  
            }*/

            /*  string username, pass;
              username = text_user.Text;
              pass=text_pass.Text;
              try
              {
                  string querry = "SELECT * FROM UserTable WHERE User = '" + text_user.Text + "' AND Password = '" + text_pass.Text + "'";
                  SqlDataAdapter sda = new SqlDataAdapter(querry,conn);
                  DataTable dtable = new DataTable();
                  sda.Fill(dtable);

                  if(dtable.Rows.Count > 0 ) 
                  {
                      username = text_user.Text;
                      pass = text_pass.Text;
                      Form2_ct f = new Form2_ct();
                      f.Show();
                  }

                MessageBox.Show("Login successful!");
              }
              catch 
              {
                  MessageBox.Show("Login Error Please try again!", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                  text_user.Clear();
                  text_pass.Clear();
              }
              finally
              {
                  conn.Close();
              }

              this.Hide();*/


        }

        private void create_Click(object sender, EventArgs e)
        {
            if (create.Text == "Create on Account?")
            {
                this.Hide();
                createaccount create = new createaccount();
                create.Show();
            }
        }

        private void showpass_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void showpass_CheckedChanged_1(object sender, EventArgs e)
        {
            if (showpass.Checked)
            {
                text_pass.PasswordChar = '\0';
            }
            else
            {
                text_pass.PasswordChar = '*';
            }
        }

        private void text_pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
        // bool checksignin(string username,string pass)
        // {
        // tim ra db de add do test
        //}

    }
}
