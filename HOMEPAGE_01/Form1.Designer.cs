namespace HOMEPAGE_01
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuVertical = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            Portfoliobtn = new Button();
            titleHeader = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            content = new Panel();
            menuVertical.SuspendLayout();
            titleHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuVertical
            // 
            menuVertical.BackColor = SystemColors.AppWorkspace;
            menuVertical.Controls.Add(button4);
            menuVertical.Controls.Add(button3);
            menuVertical.Controls.Add(button2);
            menuVertical.Controls.Add(Portfoliobtn);
            menuVertical.Dock = DockStyle.Left;
            menuVertical.Location = new Point(0, 0);
            menuVertical.Name = "menuVertical";
            menuVertical.Size = new Size(250, 650);
            menuVertical.TabIndex = 0;
            // 
            // button4
            // 
            button4.Location = new Point(6, 311);
            button4.Name = "button4";
            button4.Size = new Size(238, 46);
            button4.TabIndex = 3;
            button4.Text = "Market";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(6, 243);
            button3.Name = "button3";
            button3.Size = new Size(238, 46);
            button3.TabIndex = 2;
            button3.Text = "Deposit";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(6, 176);
            button2.Name = "button2";
            button2.Size = new Size(238, 46);
            button2.TabIndex = 1;
            button2.Text = "Trade";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Portfoliobtn
            // 
            Portfoliobtn.Location = new Point(6, 109);
            Portfoliobtn.Name = "Portfoliobtn";
            Portfoliobtn.Size = new Size(238, 46);
            Portfoliobtn.TabIndex = 0;
            Portfoliobtn.Text = "Portfolio";
            Portfoliobtn.UseVisualStyleBackColor = true;
            Portfoliobtn.Click += Portfoliobtn_Click;
            // 
            // titleHeader
            // 
            titleHeader.Controls.Add(pictureBox2);
            titleHeader.Controls.Add(pictureBox1);
            titleHeader.Dock = DockStyle.Top;
            titleHeader.Location = new Point(250, 0);
            titleHeader.Name = "titleHeader";
            titleHeader.Size = new Size(1050, 50);
            titleHeader.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1005, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(42, 41);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(6, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(42, 41);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // content
            // 
            content.BackColor = SystemColors.ControlLight;
            content.Dock = DockStyle.Fill;
            content.Location = new Point(250, 50);
            content.Name = "content";
            content.Size = new Size(1050, 600);
            content.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 650);
            Controls.Add(content);
            Controls.Add(titleHeader);
            Controls.Add(menuVertical);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            ShowInTaskbar = false;
            Text = "Form1";
            menuVertical.ResumeLayout(false);
            titleHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel menuVertical;
        private Panel titleHeader;
        private PictureBox pictureBox1;
        private Panel content;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button Portfoliobtn;
        private PictureBox pictureBox2;
    }
}