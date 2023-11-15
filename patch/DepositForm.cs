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
    public partial class DepositForm : Form
    {
        public DepositForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create an instance of the form you want to load
            WalletForm WalletForm = new WalletForm();

            // Set the TopLevel property of the form to false, so it can be hosted inside the panel
            WalletForm.TopLevel = false;

            // Clear any existing controls from the panel
            panel1.Controls.Clear();

            // Add the form to the panel's Controls collection
            panel1.Controls.Add(WalletForm);

            // Show the form
            WalletForm.Show();

            // Set the size of the form to match the panel's size
            WalletForm.Size = panel1.Size;
        }
    }
}
