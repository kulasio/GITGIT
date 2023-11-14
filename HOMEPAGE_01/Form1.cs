namespace HOMEPAGE_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (menuVertical.Width == 250)
            {
                menuVertical.Width = 70;
            }

            else
                menuVertical.Width = 250;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Create an instance of the form you want to load
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

        private void Portfoliobtn_Click(object sender, EventArgs e)
        {
            // Create an instance of the form you want to load
            PortfolioPage PortfolioPage = new PortfolioPage();

            // Set the TopLevel property of the form to false, so it can be hosted inside the panel
            PortfolioPage.TopLevel = false;

            // Clear any existing controls from the panel
            content.Controls.Clear();

            // Add the form to the panel's Controls collection
            content.Controls.Add(PortfolioPage);

            // Show the form
            PortfolioPage.Show();

            // Set the size of the form to match the panel's size
            PortfolioPage.Size = content.Size;
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            // Create an instance of the form you want to load
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
    }
}