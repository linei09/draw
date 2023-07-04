namespace WindowsFormsApp3
{
    partial class Forgot_pass
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._mail = new System.Windows.Forms.TextBox();
            this._birth = new System.Windows.Forms.TextBox();
            this.getpass = new System.Windows.Forms.Button();
            this._havepass = new System.Windows.Forms.Label();
            this._sigin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your registered email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Your birthday";
            // 
            // _mail
            // 
            this._mail.Location = new System.Drawing.Point(210, 30);
            this._mail.Name = "_mail";
            this._mail.Size = new System.Drawing.Size(100, 20);
            this._mail.TabIndex = 2;
            // 
            // _birth
            // 
            this._birth.Location = new System.Drawing.Point(210, 86);
            this._birth.Name = "_birth";
            this._birth.Size = new System.Drawing.Size(100, 20);
            this._birth.TabIndex = 3;
            // 
            // getpass
            // 
            this.getpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getpass.Location = new System.Drawing.Point(123, 188);
            this.getpass.Name = "getpass";
            this.getpass.Size = new System.Drawing.Size(106, 33);
            this.getpass.TabIndex = 4;
            this.getpass.Text = "Get password";
            this.getpass.UseVisualStyleBackColor = true;
            this.getpass.Click += new System.EventHandler(this.getpass_Click);
            // 
            // _havepass
            // 
            this._havepass.AutoSize = true;
            this._havepass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._havepass.Location = new System.Drawing.Point(101, 148);
            this._havepass.Name = "_havepass";
            this._havepass.Size = new System.Drawing.Size(77, 20);
            this._havepass.TabIndex = 6;
            this._havepass.Text = "your pass";
            // 
            // _sigin
            // 
            this._sigin.AutoSize = true;
            this._sigin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._sigin.Location = new System.Drawing.Point(363, 193);
            this._sigin.Name = "_sigin";
            this._sigin.Size = new System.Drawing.Size(57, 20);
            this._sigin.TabIndex = 7;
            this._sigin.Text = "Sign in";
            this._sigin.Click += new System.EventHandler(this._sigin_Click);
            // 
            // Forgot_pass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 254);
            this.Controls.Add(this._sigin);
            this.Controls.Add(this._havepass);
            this.Controls.Add(this.getpass);
            this.Controls.Add(this._birth);
            this.Controls.Add(this._mail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Forgot_pass";
            this.Text = "Forgot_pass";
            this.Load += new System.EventHandler(this.Forgot_pass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _mail;
        private System.Windows.Forms.TextBox _birth;
        private System.Windows.Forms.Button getpass;
        private System.Windows.Forms.Label _havepass;
        private System.Windows.Forms.Label _sigin;
    }
}