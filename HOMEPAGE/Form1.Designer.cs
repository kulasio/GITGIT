namespace HOMEPAGE
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            MenuVertical = new Panel();
            button2 = new Button();
            button1 = new Button();
            MainTitle = new Panel();
            pictureBox1 = new PictureBox();
            slidebotton = new PictureBox();
            Content = new Panel();
            contextMenuStrip1 = new ContextMenuStrip(components);
            MenuVertical.SuspendLayout();
            MainTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)slidebotton).BeginInit();
            SuspendLayout();
            // 
            // MenuVertical
            // 
            MenuVertical.BackColor = Color.FromArgb(0, 122, 204);
            MenuVertical.Controls.Add(button2);
            MenuVertical.Controls.Add(button1);
            MenuVertical.Dock = DockStyle.Left;
            MenuVertical.Location = new Point(0, 0);
            MenuVertical.Name = "MenuVertical";
            MenuVertical.Size = new Size(250, 650);
            MenuVertical.TabIndex = 0;
            MenuVertical.Paint += MenuVertical_Paint;
            // 
            // button2
            // 
            button2.Location = new Point(26, 295);
            button2.Name = "button2";
            button2.Size = new Size(186, 63);
            button2.TabIndex = 1;
            button2.Text = "trade";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(26, 450);
            button1.Name = "button1";
            button1.Size = new Size(186, 63);
            button1.TabIndex = 0;
            button1.Text = "Market";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // MainTitle
            // 
            MainTitle.BackColor = Color.WhiteSmoke;
            MainTitle.Controls.Add(pictureBox1);
            MainTitle.Controls.Add(slidebotton);
            MainTitle.Dock = DockStyle.Top;
            MainTitle.Location = new Point(250, 0);
            MainTitle.Name = "MainTitle";
            MainTitle.Size = new Size(1050, 50);
            MainTitle.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1003, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 35);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // slidebotton
            // 
            slidebotton.Image = (Image)resources.GetObject("slidebotton.Image");
            slidebotton.Location = new Point(6, 9);
            slidebotton.Name = "slidebotton";
            slidebotton.Size = new Size(35, 35);
            slidebotton.SizeMode = PictureBoxSizeMode.Zoom;
            slidebotton.TabIndex = 0;
            slidebotton.TabStop = false;
            slidebotton.Click += slidebotton_Click;
            // 
            // Content
            // 
            Content.Dock = DockStyle.Fill;
            Content.Location = new Point(250, 50);
            Content.Name = "Content";
            Content.Size = new Size(1050, 600);
            Content.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 650);
            Controls.Add(Content);
            Controls.Add(MainTitle);
            Controls.Add(MenuVertical);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            MenuVertical.ResumeLayout(false);
            MainTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)slidebotton).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel MenuVertical;
        private Panel MainTitle;
        private PictureBox slidebotton;
        private Panel Content;
        private PictureBox pictureBox1;
        private Button button1;
        private ContextMenuStrip contextMenuStrip1;
        private Button button2;
    }
}