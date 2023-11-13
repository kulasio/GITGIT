using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOMEPAGE
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Create an instance of the form you want to load
            CLStable cLStable = new CLStable();

            // Set the TopLevel property of the form to false, so it can be hosted inside the panel
            cLStable.TopLevel = false;

            // Clear any existing controls from the panel
            panel1.Controls.Clear();

            // Add the form to the panel's Controls collection
            panel1.Controls.Add(cLStable);

            // Show the form
            cLStable.Show();

            // Set the size of the form to match the panel's size
            cLStable.Size = panel1.Size;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Create an instance of the form you want to load
            GYATtable gYATtable = new GYATtable();

            // Set the TopLevel property of the form to false, so it can be hosted inside the panel
            gYATtable.TopLevel = false;

            // Clear any existing controls from the panel
            panel1.Controls.Clear();

            // Add the form to the panel's Controls collection
            panel1.Controls.Add(gYATtable);

            // Show the form
            gYATtable.Show();

            // Set the size of the form to match the panel's size
            gYATtable.Size = panel1.Size;
        }
    }
}
