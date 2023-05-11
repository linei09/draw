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

namespace WindowsFormsApp1
{
    public partial class createaccount : Form
    {
        public createaccount()
        {
            InitializeComponent();
        }

        private void name_form_Click(object sender, EventArgs e)
        {

        }

        private void Username_Click(object sender, EventArgs e)
        {

        }



        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void Validating(object sender, CancelEventArgs e)
        {

        }
        private void signup_Click(object sender, EventArgs e)
        {
            if (signup.Text == "Sign Up")
            {
                if (string.IsNullOrEmpty(text_user.Text) || string.IsNullOrEmpty(text_email.Text) || string.IsNullOrEmpty(text_pass.Text) || string.IsNullOrEmpty(text_enterpass.Text))
                {
                    MessageBox.Show("Please enter full information");
                    return;
                }
                else
                if (username_check.Visible == true || emailcheck.Visible == true || passcheck.Visible == true || repass.Visible == true)
                {
                    MessageBox.Show("Something is not right. Please recheck");
                    return;
                }
                else
                {
                    this.Hide();
                    Login f1 = new Login();
                    f1.Show();
                    SqlConnection con = new SqlConnection("Data Source=MSI;Initial Catalog=MyDB;Integrated Security=True;Pooling=False");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into UserTable values (@User,@Email,@Password )", con);
                    cmd.Parameters.AddWithValue("@User", text_user.Text);
                    cmd.Parameters.AddWithValue("@Email", text_email.Text);
                    cmd.Parameters.AddWithValue("@Password", text_pass.Text);
                    cmd.ExecuteNonQuery();

                    con.Close();
                    MessageBox.Show("Sign up successful!");
                    // con nap len db
                }
            }
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
