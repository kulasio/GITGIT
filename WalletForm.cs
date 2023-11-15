using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hompage_Final_
{
    public partial class WalletForm : Form
    {
        public WalletForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Services is not available, pls try again later ");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Services is not available, pls try again later ");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Services is not available, pls try again later ");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Services is not available, pls try again later ");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Services is not available, pls try again later ");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Services is not available, pls try again later ");
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            // Create an instance of the form you want to load
            Transaction02 Transaction02 = new Transaction02();

            // Set the TopLevel property of the form to false, so it can be hosted inside the panel
            Transaction02.TopLevel = false;

            // Clear any existing controls from the panel
            panel3.Controls.Clear();

            // Add the form to the panel's Controls collection
            panel3.Controls.Add(Transaction02);

            // Show the form
            Transaction02.Show();

            // Set the size of the form to match the panel's size
            Transaction02.Size = panel3.Size;

        }
    }
}
