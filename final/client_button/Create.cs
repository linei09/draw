using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using WindowsFormsApp3;
using System.Runtime.InteropServices.WindowsRuntime;

namespace WindowsFormsApp1
{
    public partial class createaccount : Form
    {
        public createaccount()
        {
            InitializeComponent();
        
        }

        Modify modify = new Modify();
        Cpher Cpher = new Cpher();

        private void signup_Click(object sender, EventArgs e)
        {
            string taikhoan = text_user.Text;
            string matkhau = text_pass.Text;
            string mail=text_email.Text;
            string birthday = txt_birth.Text;

            string encrypt_taikhoan = Cpher.Encrypt(taikhoan);
            string encrypt_matkhau = Cpher.Encrypt(matkhau);
            string encrypt_email = Cpher.Encrypt(mail);
            string encrypt_birth = Cpher.Encrypt(birthday);
                
            //if (modify.Users("select * from Login where email = '"+mail+"'").Count!=0)
            if (modify.Users("select * from Login where email = '" + encrypt_email + "'").Count != 0)
            {
                MessageBox.Show("Email has been uesed. Please try another!");
                return;
            }
            try
            {
                //string query = "insert into Login values('"+taikhoan+ "','"+matkhau+ "','"+mail+ "','"+birthday+"')";
                string query = "insert into Login values('" + encrypt_taikhoan + "','" + encrypt_matkhau + "','" + encrypt_email + "','" + encrypt_birth + "')";
                modify.Command(query);
                MessageBox.Show("Sign up successful!");
                text_user.Text = String.Empty;
                text_pass.Text = String.Empty;
                text_email.Text = String.Empty;
                text_enterpass.Text = String.Empty;
                txt_birth.Text = String.Empty;
            }
            catch
            {
                MessageBox.Show("Username already exists. Please try another!");
            }
           
        }



        private void name_form_Click(object sender, EventArgs e)
        {

        }

        private void Username_Click(object sender, EventArgs e)
        {

        }


        private void createaccount_Load(object sender, EventArgs e)
        {
            
        }
       
       
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private new void Validating(object sender, CancelEventArgs e)
        {

        }
      

       
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (text_user.Text.Length < 5)
            {
                username_check.Visible = true;

            }
            else
                username_check.Visible = false;
        }

        public bool IsValidEmail(string email)
        {
            try
            {
                var addr = new MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (!IsValidEmail(text_email.Text))
                emailcheck.Visible = true;

            else
                emailcheck.Visible = false;
        }

        private void textBox3_TextChanged(object sender, EventArgs e) // hide password
        {
            if (text_pass.Text.Length < 8)
                passcheck.Visible = true;

            else
                passcheck.Visible = false;
        }

        private void text_enterpass_TextChanged(object sender, EventArgs e)
        {
            if (string.Compare(text_enterpass.Text, text_pass.Text) != 0)
                repass.Visible = true;

            else
                repass.Visible = false;
        }



        private void singin_Click(object sender, EventArgs e)
        {
            if (singin.Text == "Sign In")
            {
                this.Hide();
                Login lg = new Login();
                lg.Show();
            }
        }



        private void showpass_CheckedChanged(object sender, EventArgs e)
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

        private void showpass1_CheckedChanged(object sender, EventArgs e)
        {
            if (showpass1.Checked)
            {
                text_enterpass.PasswordChar = '\0';
            }
            else
            {
                text_enterpass.PasswordChar = '*';
            }
        }

    }

}
