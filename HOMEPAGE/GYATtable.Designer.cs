namespace HOMEPAGE
{
    partial class GYATtable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GYATtable));
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(523, 3);
            label4.Name = "label4";
            label4.Size = new Size(71, 37);
            label4.TabIndex = 9;
            label4.Text = "SELL";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(81, 3);
            label3.Name = "label3";
            label3.Size = new Size(66, 37);
            label3.TabIndex = 8;
            label3.Text = "BUY";
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveBorder;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(12, -6);
            label1.Name = "label1";
            label1.Size = new Size(235, 298);
            label1.TabIndex = 5;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.ActiveBorder;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Location = new Point(439, -6);
            label2.Name = "label2";
            label2.Size = new Size(231, 298);
            label2.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(225, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(236, 236);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // GYATtable
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 287);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GYATtable";
            Text = "GYATtable";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label3;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
    }
}