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
    public partial class Transaction02 : Form
    {
        public Transaction02()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double amountDeposit = double.Parse(textBox1.Text);
            label3.Text = amountDeposit.ToString();

            MessageBox.Show("Deposit Successfull");
        }
    }
}
