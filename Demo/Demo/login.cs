using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        private int initialWidth;
        private int initialHeight;
        private int WelcomeinitialWidth;
        private int WelcomeinitialHeight;
        private int UsernameinitialWidth;
        private int UsernameinitialHeight;
        private int Text_userinitialWidth;
        private int Text_userinitialHeight;
        private int PasswwordinitialWidth;
        private int PasswwordinitialHeight;
        private int Text_passinitialWidth;
        private int Text_passinitialHeight;
        private int ShowpassinitialWidth;
        private int ShowpassinitialHeight;
        private int SignininitialWidth;
        private int SignininitialHeight;
        private int ForgotinitialWidth;
        private int ForgotinitialHeight;
        private int CreateinitialWidth;
        private int CreateinitialHeight;


        public Login()
        {
            InitializeComponent();
            this.initialHeight = this.Height;
            this.initialWidth = this.Width;
            this.WelcomeinitialWidth = this.welcome.Width;
            this.WelcomeinitialHeight = this.welcome.Height;
             
            this.UsernameinitialHeight = this.username.Height;
            this.UsernameinitialWidth = this.username.Width;

            this.Text_userinitialHeight = this.text_user.Height;
            this.Text_userinitialWidth = this.text_user.Width;

            this.PasswwordinitialHeight = this.password.Height;
            this.PasswwordinitialWidth = this.password.Width;

            this.Text_passinitialHeight = this.text_pass.Height;
            this.Text_passinitialWidth = this.text_pass.Width;

            this.ShowpassinitialHeight = this.showpass.Height;
            this.ShowpassinitialWidth = this.showpass.Width;

            this.SignininitialHeight = this.signin.Height;
            this.SignininitialWidth = this.signin.Width;

            this.ForgotinitialHeight = this.forgot.Height;
            this.ForgotinitialWidth = this.forgot.Width;

            this.CreateinitialHeight = this.create.Height;
            this.CreateinitialWidth = this.create.Width;
        }
        private void formlogin_SizeChanged(object sender, EventArgs e)
        {
            float ratioWidth = (float)this.Width / (float)this.initialWidth;
            float ratioHeight = (float)this.Height / (float)this.initialHeight;
            this.initialWidth = this.Width;
            this.initialHeight = this.Height;
            this.welcome.Width = (int)(this.WelcomeinitialWidth * ratioWidth);
            this.welcome.Height = (int)(this.WelcomeinitialHeight * ratioHeight);
            this.username.Width = (int)(this.UsernameinitialWidth * ratioWidth);
            this.username.Height = (int)(this.UsernameinitialHeight * ratioHeight);
            this.text_user.Width = (int)(this.Text_userinitialWidth * ratioWidth);
            this.text_user.Height = (int)(this.Text_userinitialHeight * ratioHeight);
            this.password.Width = (int)(this.PasswwordinitialHeight * ratioWidth);
            this.password.Height = (int)(this.PasswwordinitialWidth * ratioHeight);
            this.text_pass.Width = (int)(this.UsernameinitialWidth * ratioWidth);
            this.text_pass.Height = (int)(this.Text_passinitialHeight * ratioHeight);
            this.showpass.Width = (int)(this.ShowpassinitialWidth * ratioWidth);
            this.showpass.Height = (int)(this.ShowpassinitialHeight * ratioHeight);
            this.signin.Width = (int)(this.SignininitialWidth * ratioWidth);
            this.signin.Height = (int)(this.SignininitialHeight * ratioHeight);
            this.forgot.Width = (int)(this.ForgotinitialWidth * ratioWidth);
            this.forgot.Height = (int)(this.ForgotinitialHeight * ratioHeight);
            this.create.Width = (int)(this.CreateinitialWidth * ratioWidth);
            this.create.Height = (int)(this.CreateinitialHeight * ratioHeight);
            welcome.Size = new Size(this.WelcomeinitialWidth, this.WelcomeinitialHeight);
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
   

        private void forgot_Click(object sender, EventArgs e)
        {
            if(forgot.Text== "Forgot password?")
            {

            }    
        }

        private void signin_Click(object sender, EventArgs e)
        {/*
            if (signin.Text=="Sign in"// && check_signin(username.Text,password.Text) == true)
            {
                Form2_ct f = new Form2_ct();
                f.Show(); // co file chinh thi doi lai thanh file chinh
                this.Hide();
            }    
            */
        }

        private void create_Click(object sender, EventArgs e)
        {
            if(create.Text== "Create on Account?")
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

        private void pictureBox2_Click(object sender, EventArgs e)
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
