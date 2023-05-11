
namespace WindowsFormsApp1
{
    partial class createaccount
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(createaccount));
            this.name_form = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.text_user = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.text_email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.text_pass = new System.Windows.Forms.TextBox();
            this.text_enterpass = new System.Windows.Forms.TextBox();
            this.signup = new System.Windows.Forms.Button();
            this.singin = new System.Windows.Forms.Label();
            this.showpass = new System.Windows.Forms.CheckBox();
            this.showpass1 = new System.Windows.Forms.CheckBox();
            this.username_check = new System.Windows.Forms.Label();
            this.emailcheck = new System.Windows.Forms.Label();
            this.passcheck = new System.Windows.Forms.Label();
            this.repass = new System.Windows.Forms.Label();
            this.txt_birth = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // name_form
            // 
            this.name_form.AutoSize = true;
            this.name_form.BackColor = System.Drawing.Color.Transparent;
            this.name_form.Font = new System.Drawing.Font("Cambria", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_form.Location = new System.Drawing.Point(188, 54);
            this.name_form.Name = "name_form";
            this.name_form.Size = new System.Drawing.Size(261, 41);
            this.name_form.TabIndex = 0;
            this.name_form.Text = "Create Account";
            this.name_form.Click += new System.EventHandler(this.name_form_Click);
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.BackColor = System.Drawing.Color.Transparent;
            this.Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.Location = new System.Drawing.Point(73, 115);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(83, 20);
            this.Username.TabIndex = 1;
            this.Username.Text = "Username";
            this.Username.Click += new System.EventHandler(this.Username_Click);
            // 
            // text_user
            // 
            this.text_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_user.Location = new System.Drawing.Point(238, 108);
            this.text_user.Multiline = true;
            this.text_user.Name = "text_user";
            this.text_user.Size = new System.Drawing.Size(238, 28);
            this.text_user.TabIndex = 2;
            this.text_user.UseWaitCursor = true;
            this.text_user.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Email";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // text_email
            // 
            this.text_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_email.Location = new System.Drawing.Point(238, 183);
            this.text_email.Multiline = true;
            this.text_email.Name = "text_email";
            this.text_email.Size = new System.Drawing.Size(238, 28);
            this.text_email.TabIndex = 5;
            this.text_email.UseWaitCursor = true;
            this.text_email.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(73, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(73, 379);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Enter the password";
            // 
            // text_pass
            // 
            this.text_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_pass.HideSelection = false;
            this.text_pass.Location = new System.Drawing.Point(238, 301);
            this.text_pass.Multiline = true;
            this.text_pass.Name = "text_pass";
            this.text_pass.PasswordChar = '*';
            this.text_pass.Size = new System.Drawing.Size(238, 28);
            this.text_pass.TabIndex = 8;
            this.text_pass.UseWaitCursor = true;
            this.text_pass.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // text_enterpass
            // 
            this.text_enterpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_enterpass.Location = new System.Drawing.Point(238, 371);
            this.text_enterpass.Multiline = true;
            this.text_enterpass.Name = "text_enterpass";
            this.text_enterpass.PasswordChar = '*';
            this.text_enterpass.Size = new System.Drawing.Size(238, 28);
            this.text_enterpass.TabIndex = 9;
            this.text_enterpass.UseWaitCursor = true;
            this.text_enterpass.TextChanged += new System.EventHandler(this.text_enterpass_TextChanged);
            // 
            // signup
            // 
            this.signup.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup.Location = new System.Drawing.Point(211, 452);
            this.signup.Name = "signup";
            this.signup.Size = new System.Drawing.Size(113, 36);
            this.signup.TabIndex = 10;
            this.signup.Text = "Sign Up";
            this.signup.UseVisualStyleBackColor = true;
            this.signup.Click += new System.EventHandler(this.signup_Click);
            // 
            // singin
            // 
            this.singin.AutoSize = true;
            this.singin.BackColor = System.Drawing.Color.Transparent;
            this.singin.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.singin.Location = new System.Drawing.Point(35, 500);
            this.singin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.singin.Name = "singin";
            this.singin.Size = new System.Drawing.Size(60, 19);
            this.singin.TabIndex = 11;
            this.singin.Text = "Sign In";
            this.singin.Click += new System.EventHandler(this.singin_Click);
            // 
            // showpass
            // 
            this.showpass.AutoSize = true;
            this.showpass.Location = new System.Drawing.Point(492, 314);
            this.showpass.Margin = new System.Windows.Forms.Padding(2);
            this.showpass.Name = "showpass";
            this.showpass.Size = new System.Drawing.Size(15, 14);
            this.showpass.TabIndex = 12;
            this.showpass.UseVisualStyleBackColor = true;
            this.showpass.CheckedChanged += new System.EventHandler(this.showpass_CheckedChanged);
            // 
            // showpass1
            // 
            this.showpass1.AutoSize = true;
            this.showpass1.Location = new System.Drawing.Point(492, 386);
            this.showpass1.Margin = new System.Windows.Forms.Padding(2);
            this.showpass1.Name = "showpass1";
            this.showpass1.Size = new System.Drawing.Size(15, 14);
            this.showpass1.TabIndex = 13;
            this.showpass1.UseVisualStyleBackColor = true;
            this.showpass1.CheckedChanged += new System.EventHandler(this.showpass1_CheckedChanged);
            // 
            // username_check
            // 
            this.username_check.AutoSize = true;
            this.username_check.BackColor = System.Drawing.Color.Transparent;
            this.username_check.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_check.ForeColor = System.Drawing.Color.Red;
            this.username_check.Location = new System.Drawing.Point(235, 148);
            this.username_check.Name = "username_check";
            this.username_check.Size = new System.Drawing.Size(320, 20);
            this.username_check.TabIndex = 1;
            this.username_check.Text = "Username must be longer than 5 characters";
            this.username_check.Visible = false;
            // 
            // emailcheck
            // 
            this.emailcheck.AutoSize = true;
            this.emailcheck.BackColor = System.Drawing.Color.Transparent;
            this.emailcheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailcheck.ForeColor = System.Drawing.Color.Red;
            this.emailcheck.Location = new System.Drawing.Point(235, 221);
            this.emailcheck.Name = "emailcheck";
            this.emailcheck.Size = new System.Drawing.Size(95, 20);
            this.emailcheck.TabIndex = 1;
            this.emailcheck.Text = "Invalid email";
            this.emailcheck.Visible = false;
            // 
            // passcheck
            // 
            this.passcheck.AutoSize = true;
            this.passcheck.BackColor = System.Drawing.Color.Transparent;
            this.passcheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passcheck.ForeColor = System.Drawing.Color.Red;
            this.passcheck.Location = new System.Drawing.Point(235, 339);
            this.passcheck.Name = "passcheck";
            this.passcheck.Size = new System.Drawing.Size(294, 20);
            this.passcheck.TabIndex = 1;
            this.passcheck.Text = "Password must be more than 8 numbers";
            this.passcheck.Visible = false;
            // 
            // repass
            // 
            this.repass.AutoSize = true;
            this.repass.BackColor = System.Drawing.Color.Transparent;
            this.repass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repass.ForeColor = System.Drawing.Color.Red;
            this.repass.Location = new System.Drawing.Point(235, 416);
            this.repass.Name = "repass";
            this.repass.Size = new System.Drawing.Size(192, 20);
            this.repass.TabIndex = 1;
            this.repass.Text = "Password does not match";
            this.repass.Visible = false;
            // 
            // txt_birth
            // 
            this.txt_birth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_birth.Location = new System.Drawing.Point(238, 255);
            this.txt_birth.Multiline = true;
            this.txt_birth.Name = "txt_birth";
            this.txt_birth.Size = new System.Drawing.Size(238, 28);
            this.txt_birth.TabIndex = 15;
            this.txt_birth.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Birth";
            // 
            // createaccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(592, 555);
            this.Controls.Add(this.txt_birth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showpass1);
            this.Controls.Add(this.showpass);
            this.Controls.Add(this.singin);
            this.Controls.Add(this.signup);
            this.Controls.Add(this.text_enterpass);
            this.Controls.Add(this.text_pass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.text_email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_user);
            this.Controls.Add(this.repass);
            this.Controls.Add(this.passcheck);
            this.Controls.Add(this.emailcheck);
            this.Controls.Add(this.username_check);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.name_form);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(608, 594);
            this.MinimumSize = new System.Drawing.Size(608, 594);
            this.Name = "createaccount";
            this.Text = "createaccount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name_form;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.TextBox text_user;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox text_pass;
        private System.Windows.Forms.TextBox text_enterpass;
        private System.Windows.Forms.Button signup;
        private System.Windows.Forms.Label singin;
        private System.Windows.Forms.CheckBox showpass;
        private System.Windows.Forms.CheckBox showpass1;
        private System.Windows.Forms.Label username_check;
        private System.Windows.Forms.Label emailcheck;
        private System.Windows.Forms.Label passcheck;
        private System.Windows.Forms.Label repass;
        private System.Windows.Forms.TextBox txt_birth;
        private System.Windows.Forms.Label label1;
    }
}