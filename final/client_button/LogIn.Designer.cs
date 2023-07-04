

namespace WindowsFormsApp1
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.welcome = new System.Windows.Forms.Label();
            this.text_pass = new System.Windows.Forms.TextBox();
            this.signin = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.text_user = new System.Windows.Forms.TextBox();
            this.forgot = new System.Windows.Forms.Label();
            this.create = new System.Windows.Forms.Label();
            this.showpass = new System.Windows.Forms.CheckBox();
            this.pictureBox_username = new System.Windows.Forms.PictureBox();
            this.pictureBox_password = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_username)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_password)).BeginInit();
            this.SuspendLayout();
            // 
            // welcome
            // 
            this.welcome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.welcome.AutoSize = true;
            this.welcome.BackColor = System.Drawing.Color.Transparent;
            this.welcome.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome.ForeColor = System.Drawing.Color.Black;
            this.welcome.Location = new System.Drawing.Point(301, 80);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(216, 26);
            this.welcome.TabIndex = 0;
            this.welcome.Text = "Welcome to (NAME)";
            this.welcome.Click += new System.EventHandler(this.label1_Click);
            // 
            // text_pass
            // 
            this.text_pass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_pass.ForeColor = System.Drawing.Color.Black;
            this.text_pass.Location = new System.Drawing.Point(291, 208);
            this.text_pass.Multiline = true;
            this.text_pass.Name = "text_pass";
            this.text_pass.PasswordChar = '*';
            this.text_pass.Size = new System.Drawing.Size(251, 34);
            this.text_pass.TabIndex = 4;
            this.text_pass.TextChanged += new System.EventHandler(this.text_pass_TextChanged);
            // 
            // signin
            // 
            this.signin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.signin.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signin.ForeColor = System.Drawing.Color.Black;
            this.signin.Location = new System.Drawing.Point(344, 292);
            this.signin.Name = "signin";
            this.signin.Size = new System.Drawing.Size(131, 34);
            this.signin.TabIndex = 5;
            this.signin.Text = "Sign in";
            this.signin.UseVisualStyleBackColor = true;
            this.signin.Click += new System.EventHandler(this.signin_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(422, 300);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 20);
            this.linkLabel1.TabIndex = 6;
            // 
            // linkLabel2
            // 
            this.linkLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel2.LinkColor = System.Drawing.Color.Black;
            this.linkLabel2.Location = new System.Drawing.Point(400, 368);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(0, 20);
            this.linkLabel2.TabIndex = 7;
            // 
            // text_user
            // 
            this.text_user.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_user.ForeColor = System.Drawing.Color.Black;
            this.text_user.Location = new System.Drawing.Point(291, 140);
            this.text_user.Multiline = true;
            this.text_user.Name = "text_user";
            this.text_user.Size = new System.Drawing.Size(251, 34);
            this.text_user.TabIndex = 8;
            this.text_user.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // forgot
            // 
            this.forgot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.forgot.BackColor = System.Drawing.Color.Transparent;
            this.forgot.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgot.ForeColor = System.Drawing.Color.Black;
            this.forgot.Location = new System.Drawing.Point(289, 245);
            this.forgot.Name = "forgot";
            this.forgot.Size = new System.Drawing.Size(147, 34);
            this.forgot.TabIndex = 9;
            this.forgot.Text = "Forgot password?";
            this.forgot.Click += new System.EventHandler(this.forgot_Click);
            // 
            // create
            // 
            this.create.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.create.AutoSize = true;
            this.create.BackColor = System.Drawing.Color.Transparent;
            this.create.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create.ForeColor = System.Drawing.Color.Black;
            this.create.Location = new System.Drawing.Point(423, 245);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(120, 13);
            this.create.TabIndex = 10;
            this.create.Text = "Create on Account?";
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // showpass
            // 
            this.showpass.AutoSize = true;
            this.showpass.Location = new System.Drawing.Point(554, 228);
            this.showpass.Margin = new System.Windows.Forms.Padding(2);
            this.showpass.Name = "showpass";
            this.showpass.Size = new System.Drawing.Size(15, 14);
            this.showpass.TabIndex = 11;
            this.showpass.UseVisualStyleBackColor = true;
            this.showpass.CheckedChanged += new System.EventHandler(this.showpass_CheckedChanged_1);
            // 
            // pictureBox_username
            // 
            this.pictureBox_username.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_username.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_username.Image")));
            this.pictureBox_username.Location = new System.Drawing.Point(247, 140);
            this.pictureBox_username.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_username.Name = "pictureBox_username";
            this.pictureBox_username.Size = new System.Drawing.Size(39, 33);
            this.pictureBox_username.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_username.TabIndex = 13;
            this.pictureBox_username.TabStop = false;
            // 
            // pictureBox_password
            // 
            this.pictureBox_password.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_password.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_password.Image")));
            this.pictureBox_password.Location = new System.Drawing.Point(247, 208);
            this.pictureBox_password.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_password.Name = "pictureBox_password";
            this.pictureBox_password.Size = new System.Drawing.Size(39, 33);
            this.pictureBox_password.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_password.TabIndex = 13;
            this.pictureBox_password.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(796, 441);
            this.Controls.Add(this.pictureBox_password);
            this.Controls.Add(this.pictureBox_username);
            this.Controls.Add(this.showpass);
            this.Controls.Add(this.create);
            this.Controls.Add(this.forgot);
            this.Controls.Add(this.text_user);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.signin);
            this.Controls.Add(this.text_pass);
            this.Controls.Add(this.welcome);
            this.MaximumSize = new System.Drawing.Size(812, 480);
            this.MinimumSize = new System.Drawing.Size(812, 480);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_username)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_password)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.TextBox text_pass;
        private System.Windows.Forms.Button signin;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.TextBox text_user;
        private System.Windows.Forms.Label forgot;
        private System.Windows.Forms.Label create;
        private System.Windows.Forms.CheckBox showpass;
        private System.Windows.Forms.PictureBox pictureBox_username;
        private System.Windows.Forms.PictureBox pictureBox_password;
    }
}
