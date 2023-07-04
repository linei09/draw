using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace WindowsFormsApp3
{
    public partial class Forgot_pass : Form
    {
        public Forgot_pass()
        {
            InitializeComponent();
            _havepass.Text = "";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        Modify modify = new Modify();
        Cpher Cpher = new Cpher();

        private void getpass_Click(object sender, EventArgs e)
        {
            string mail = _mail.Text;
            string birthday = _birth.Text;

            string encrypt_mail = Cpher.Encrypt(mail);
            string encrpyt_birth = Cpher.Encrypt(birthday);

            if (mail.Trim() == "")
                MessageBox.Show("Please enter your registered email");
            else if (birthday.Trim() =="")
                MessageBox.Show("Please enter your registered birthday");
            else
            {
                //string query = "select * from Login where email = '"+mail+"' and birth = '"+birthday+"'";
                string query = "select * from Login where email = '" + encrypt_mail + "' and birth = '" + encrpyt_birth + "'";
                if (modify.Users(query).Count != 0) 
                {
                    _havepass.ForeColor = Color.Green;
                    //_havepass.Text = "Your password: "+modify.Users(query)[0].Password;
                    _havepass.Text = "Your password: " +Cpher.Decrypt((modify.Users(query)[0].Password));
                }
                else
                {
                    _havepass.ForeColor = Color.Red;
                    _havepass.Text = "Incorrect information!";
                }
            }
        }

        private void _sigin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lg = new Login();
            lg.Show();
        }

        private void Forgot_pass_Load(object sender, EventArgs e)
        {

        }
    }
}
