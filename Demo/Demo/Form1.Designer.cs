namespace Demo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asViewerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Undo = new System.Windows.Forms.Button();
            this.Redo = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this._text = new System.Windows.Forms.Button();
            this.Color = new System.Windows.Forms.Button();
            this.Polygons = new System.Windows.Forms.Button();
            this.Eraser = new System.Windows.Forms.Button();
            this.Pen = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.shareToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1184, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.newToolStripMenuItem.Text = "&New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(143, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.versionToolStripMenuItem,
            this.contactUsToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // versionToolStripMenuItem
            // 
            this.versionToolStripMenuItem.Name = "versionToolStripMenuItem";
            this.versionToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.versionToolStripMenuItem.Text = "Contact Us";
            // 
            // contactUsToolStripMenuItem
            // 
            this.contactUsToolStripMenuItem.Name = "contactUsToolStripMenuItem";
            this.contactUsToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.contactUsToolStripMenuItem.Text = "Version";
            // 
            // shareToolStripMenuItem
            // 
            this.shareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asEditorToolStripMenuItem,
            this.asViewerToolStripMenuItem});
            this.shareToolStripMenuItem.Name = "shareToolStripMenuItem";
            this.shareToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.shareToolStripMenuItem.Text = "Share";
            // 
            // asEditorToolStripMenuItem
            // 
            this.asEditorToolStripMenuItem.Name = "asEditorToolStripMenuItem";
            this.asEditorToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.asEditorToolStripMenuItem.Text = "As Editor";
            // 
            // asViewerToolStripMenuItem
            // 
            this.asViewerToolStripMenuItem.Name = "asViewerToolStripMenuItem";
            this.asViewerToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.asViewerToolStripMenuItem.Text = "As Viewer";
            // 
            // Undo
            // 
            this.Undo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Undo.BackgroundImage")));
            this.Undo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Undo.Location = new System.Drawing.Point(23, 113);
            this.Undo.Name = "Undo";
            this.Undo.Size = new System.Drawing.Size(30, 30);
            this.Undo.TabIndex = 1;
            this.Undo.UseVisualStyleBackColor = true;
            // 
            // Redo
            // 
            this.Redo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Redo.BackgroundImage")));
            this.Redo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Redo.Location = new System.Drawing.Point(64, 113);
            this.Redo.Name = "Redo";
            this.Redo.Size = new System.Drawing.Size(30, 30);
            this.Redo.TabIndex = 2;
            this.Redo.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.Location = new System.Drawing.Point(600, 550);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 20);
            this.button3.TabIndex = 3;
            this.button3.Text = ">";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button4.Location = new System.Drawing.Point(550, 550);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(50, 20);
            this.button4.TabIndex = 4;
            this.button4.Text = "<";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "(*.pdf)|*.pdf";
            // 
            // saveFileDialog2
            // 
            this.saveFileDialog2.Filter = "(*.pdf)|*.pdf";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(100, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 510);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(250, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 510);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this._text);
            this.panel2.Controls.Add(this.Color);
            this.panel2.Controls.Add(this.Polygons);
            this.panel2.Controls.Add(this.Eraser);
            this.panel2.Controls.Add(this.Pen);
            this.panel2.Location = new System.Drawing.Point(1120, 180);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(60, 210);
            this.panel2.TabIndex = 7;
            // 
            // _text
            // 
            this._text.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_text.BackgroundImage")));
            this._text.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._text.Location = new System.Drawing.Point(15, 170);
            this._text.Name = "_text";
            this._text.Size = new System.Drawing.Size(30, 30);
            this._text.TabIndex = 4;
            this._text.UseVisualStyleBackColor = true;
            // 
            // Color
            // 
            this.Color.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Color.BackgroundImage")));
            this.Color.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Color.Location = new System.Drawing.Point(15, 130);
            this.Color.Name = "Color";
            this.Color.Size = new System.Drawing.Size(30, 30);
            this.Color.TabIndex = 3;
            this.Color.UseVisualStyleBackColor = true;
            // 
            // Polygons
            // 
            this.Polygons.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Polygons.BackgroundImage")));
            this.Polygons.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Polygons.Location = new System.Drawing.Point(15, 90);
            this.Polygons.Name = "Polygons";
            this.Polygons.Size = new System.Drawing.Size(30, 30);
            this.Polygons.TabIndex = 2;
            this.Polygons.UseVisualStyleBackColor = true;
            // 
            // Eraser
            // 
            this.Eraser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Eraser.BackgroundImage")));
            this.Eraser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Eraser.Location = new System.Drawing.Point(15, 50);
            this.Eraser.Name = "Eraser";
            this.Eraser.Size = new System.Drawing.Size(30, 30);
            this.Eraser.TabIndex = 1;
            this.Eraser.UseVisualStyleBackColor = true;
            // 
            // Pen
            // 
            this.Pen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Pen.BackgroundImage")));
            this.Pen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pen.Location = new System.Drawing.Point(15, 10);
            this.Pen.Name = "Pen";
            this.Pen.Size = new System.Drawing.Size(30, 30);
            this.Pen.TabIndex = 0;
            this.Pen.UseVisualStyleBackColor = true;
            this.Pen.Click += new System.EventHandler(this.Pen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 611);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Redo);
            this.Controls.Add(this.Undo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asEditorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asViewerToolStripMenuItem;
        private System.Windows.Forms.Button Undo;
        private System.Windows.Forms.Button Redo;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Pen;
        private System.Windows.Forms.Button _text;
        private System.Windows.Forms.Button Color;
        private System.Windows.Forms.Button Polygons;
        private System.Windows.Forms.Button Eraser;
    }
}

