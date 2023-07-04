using Demo;
using System;
using System.Collections;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void forgot_Click(object sender, EventArgs e)
        {
            if (forgot.Text == "Forgot password?")
            {
                this.Hide();
                Forgot_pass fg = new Forgot_pass();
                fg.Show();
            }
        }
        private bool isValid()
        {
            if(text_user.Text==string.Empty || text_pass.Text==string.Empty)
            
                MessageBox.Show("Please enter user or password!","Error");
            
            return true;
        }
       
        Modify modify = new Modify();
        Cpher cipher = new Cpher();

        private void signin_Click(object sender, EventArgs e)
        {
            string taikhoan=text_user.Text;
            string matkhau=text_pass.Text;
            string encrypt_taikhoan = Cpher.Encrypt(taikhoan);
            string encrypt_matkhau = Cpher.Encrypt(matkhau);

            if (taikhoan.Trim() == "" || matkhau.Trim() =="")
               MessageBox.Show("Please enter username or password again!");
            else
            {
                //string query = "Select * from Login where username = '"+taikhoan+"' and password = '"+matkhau+"'";
                string query = "Select * from Login where username = '" + encrypt_taikhoan + "' and password = '" + encrypt_matkhau + "'";
                if (modify.Users(query).Count != 0)
                {
                    MessageBox.Show("Log in successful!","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    
                    this.Hide();
                    Form1 pt = new Form1(taikhoan);
                    pt.Show();
                }
                else
                {
                   MessageBox.Show("Invalid username or password. Please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
        

    }
}
