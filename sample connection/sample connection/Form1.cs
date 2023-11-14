using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace sample_connection
{
    public partial class Form1 : Form
    {
        private MySqlConnection connection;
        private MySqlDataAdapter dataAdapter;
        private DataSet dataSet;

        public Form1()
        {
            InitializeComponent();
            InitializeDatabase();
        }

        private void InitializeDatabase()
        {
            string connectionString = "server=127.0.0.1; user=root; database=sample; password=";
            connection = new MySqlConnection(connectionString);
            dataAdapter = new MySqlDataAdapter("SELECT * FROM Users", connection);

            dataSet = new DataSet();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string email = textBox2.Text;
            string password = textBox3.Text;

            // Validate input
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string insertQuery = $"INSERT INTO Users (Name, Email, Password) VALUES ('{name}', '{email}', '{password}')";

            
            try
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(insertQuery, connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form2 f2 = new Form2();
                f2.ShowDialog();
               


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
