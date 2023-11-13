using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;


namespace HOMEPAGE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void slidebotton_Click(object sender, EventArgs e)
        {

            if (MenuVertical.Width == 250)
            {
                MenuVertical.Width = 70;
            }

            else
                MenuVertical.Width = 250;
        }

        private void MenuVertical_Paint(object sender, PaintEventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            // Create an instance of the form you want to load
            Form2 form2 = new Form2();

            // Set the TopLevel property of the form to false, so it can be hosted inside the panel
            form2.TopLevel = false;

            // Clear any existing controls from the panel
            Content.Controls.Clear();

            // Add the form to the panel's Controls collection
            Content.Controls.Add(form2);

            // Show the form
            form2.Show();

            // Set the size of the form to match the panel's size
            form2.Size = Content.Size;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Create an instance of the form you want to load
            Form3 form3 = new Form3();

            // Set the TopLevel property of the form to false, so it can be hosted inside the panel
            form3.TopLevel = false;

            // Clear any existing controls from the panel
            Content.Controls.Clear();

            // Add the form to the panel's Controls collection
            Content.Controls.Add(form3);

            // Show the form
            form3.Show();

            // Set the size of the form to match the panel's size
            form3.Size = Content.Size;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}