namespace import_picture_test
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Line = new System.Windows.Forms.Button();
            this.BtnRectangle = new System.Windows.Forms.Button();
            this.BtnEllipse = new System.Windows.Forms.Button();
            this.BtnEraser = new System.Windows.Forms.Button();
            this.BtnPencil = new System.Windows.Forms.Button();
            this.BtnFill = new System.Windows.Forms.Button();
            this.BtnColor = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pointx = new System.Windows.Forms.TextBox();
            this.pointy = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(10, 456);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Import";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.Location = new System.Drawing.Point(342, 457);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(674, 457);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Export";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.Line);
            this.panel1.Controls.Add(this.BtnRectangle);
            this.panel1.Controls.Add(this.BtnEllipse);
            this.panel1.Controls.Add(this.BtnEraser);
            this.panel1.Controls.Add(this.BtnPencil);
            this.panel1.Controls.Add(this.BtnFill);
            this.panel1.Controls.Add(this.BtnColor);
            this.panel1.Location = new System.Drawing.Point(799, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(93, 356);
            this.panel1.TabIndex = 4;
            // 
            // Line
            // 
            this.Line.Location = new System.Drawing.Point(0, 245);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(93, 30);
            this.Line.TabIndex = 6;
            this.Line.Text = "Line";
            this.Line.UseVisualStyleBackColor = true;
            // 
            // BtnRectangle
            // 
            this.BtnRectangle.Location = new System.Drawing.Point(0, 209);
            this.BtnRectangle.Name = "BtnRectangle";
            this.BtnRectangle.Size = new System.Drawing.Size(93, 30);
            this.BtnRectangle.TabIndex = 5;
            this.BtnRectangle.Text = "Rectangle";
            this.BtnRectangle.UseVisualStyleBackColor = true;
            // 
            // BtnEllipse
            // 
            this.BtnEllipse.Location = new System.Drawing.Point(0, 173);
            this.BtnEllipse.Name = "BtnEllipse";
            this.BtnEllipse.Size = new System.Drawing.Size(93, 30);
            this.BtnEllipse.TabIndex = 4;
            this.BtnEllipse.Text = "Ellipse";
            this.BtnEllipse.UseVisualStyleBackColor = true;
            this.BtnEllipse.Click += new System.EventHandler(this.BtnEllipse_Click);
            // 
            // BtnEraser
            // 
            this.BtnEraser.Location = new System.Drawing.Point(0, 137);
            this.BtnEraser.Name = "BtnEraser";
            this.BtnEraser.Size = new System.Drawing.Size(93, 30);
            this.BtnEraser.TabIndex = 3;
            this.BtnEraser.Text = "Eraser";
            this.BtnEraser.UseVisualStyleBackColor = true;
            this.BtnEraser.Click += new System.EventHandler(this.BtnEraser_Click);
            // 
            // BtnPencil
            // 
            this.BtnPencil.Location = new System.Drawing.Point(0, 101);
            this.BtnPencil.Name = "BtnPencil";
            this.BtnPencil.Size = new System.Drawing.Size(93, 30);
            this.BtnPencil.TabIndex = 2;
            this.BtnPencil.Text = "Pencil";
            this.BtnPencil.UseVisualStyleBackColor = true;
            this.BtnPencil.Click += new System.EventHandler(this.BtnPencil_Click);
            // 
            // BtnFill
            // 
            this.BtnFill.Location = new System.Drawing.Point(0, 65);
            this.BtnFill.Name = "BtnFill";
            this.BtnFill.Size = new System.Drawing.Size(93, 30);
            this.BtnFill.TabIndex = 1;
            this.BtnFill.Text = "FIll";
            this.BtnFill.UseVisualStyleBackColor = true;
            // 
            // BtnColor
            // 
            this.BtnColor.Location = new System.Drawing.Point(0, 29);
            this.BtnColor.Name = "BtnColor";
            this.BtnColor.Size = new System.Drawing.Size(93, 30);
            this.BtnColor.TabIndex = 0;
            this.BtnColor.Text = "Color";
            this.BtnColor.UseVisualStyleBackColor = true;
            this.BtnColor.Click += new System.EventHandler(this.BtnColor_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(799, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(93, 23);
            this.panel2.TabIndex = 0;
            // 
            // pointx
            // 
            this.pointx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pointx.Location = new System.Drawing.Point(799, 415);
            this.pointx.Name = "pointx";
            this.pointx.Size = new System.Drawing.Size(100, 20);
            this.pointx.TabIndex = 5;
            // 
            // pointy
            // 
            this.pointy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pointy.Location = new System.Drawing.Point(800, 442);
            this.pointy.Name = "pointy";
            this.pointy.Size = new System.Drawing.Size(100, 20);
            this.pointy.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox1.Location = new System.Drawing.Point(10, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(783, 438);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(904, 501);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pointy);
            this.Controls.Add(this.pointx);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Line;
        private System.Windows.Forms.Button BtnRectangle;
        private System.Windows.Forms.Button BtnEllipse;
        private System.Windows.Forms.Button BtnEraser;
        private System.Windows.Forms.Button BtnPencil;
        private System.Windows.Forms.Button BtnFill;
        private System.Windows.Forms.Button BtnColor;
        private System.Windows.Forms.TextBox pointx;
        private System.Windows.Forms.TextBox pointy;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

