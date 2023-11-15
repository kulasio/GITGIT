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
    public partial class HomepageForm : Form
    {
        public HomepageForm()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (menuVertical.Width == 250)
            {
                menuVertical.Width = 70;
              
            }
            else
            {
                menuVertical.Width = 250;
             
            }
        }
        private void Dashboard_Click(object sender, EventArgs e)
        {
            // Create an instance of the form you want to load
            DashboardForm DashboardForm = new DashboardForm();

            // Set the TopLevel property of the form to false, so it can be hosted inside the panel
            DashboardForm.TopLevel = false;

            // Clear any existing controls from the panel
            content.Controls.Clear();

            // Add the form to the panel's Controls collection
            content.Controls.Add(DashboardForm);

            // Show the form
            DashboardForm.Show();

            // Set the size of the form to match the panel's size
            DashboardForm.Size = content.Size;
        }

        private void Trade_Click(object sender, EventArgs e)
        {
            // Create an instance of the form you want to load
            TradeForm TradeForm = new TradeForm();

            // Set the TopLevel property of the form to false, so it can be hosted inside the panel
            TradeForm.TopLevel = false;

            // Clear any existing controls from the panel
            content.Controls.Clear();

            // Add the form to the panel's Controls collection
            content.Controls.Add(TradeForm);

            // Show the form
            TradeForm.Show();

            // Set the size of the form to match the panel's size
            TradeForm.Size = content.Size;
        }

        private void Deposit_Click(object sender, EventArgs e)
        {
            DepositForm DepositForm = new DepositForm();

            // Set the TopLevel property of the form to false, so it can be hosted inside the panel
            DepositForm.TopLevel = false;

            // Clear any existing controls from the panel
            content.Controls.Clear();

            // Add the form to the panel's Controls collection
            content.Controls.Add(DepositForm);

            // Show the form
            DepositForm.Show();

            // Set the size of the form to match the panel's size
            DepositForm.Size = content.Size;
        }

        private void Market_Click(object sender, EventArgs e)
        {
           MarketForm MarketForm = new MarketForm();

            // Set the TopLevel property of the form to false, so it can be hosted inside the panel
            MarketForm.TopLevel = false;

            // Clear any existing controls from the panel
            content.Controls.Clear();

            // Add the form to the panel's Controls collection
            content.Controls.Add(MarketForm);

            // Show the form
            MarketForm.Show();

            // Set the size of the form to match the panel's size
            MarketForm.Size = content.Size;
        }
    }
}
