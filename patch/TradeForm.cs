using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MySql.Data.MySqlClient;

namespace Hompage_Final_
{
    public partial class TradeForm : Form
    {
        private Series candlestickSeries;
        private int currentIndex = 0;
        private const int MaxCandlestickHeight = 100; // Adjust this value as needed
        private MySqlConnection connection;
        
        public TradeForm()
        {
            InitializeComponent();
            InitializeDatabase();
            InitializeChart();
        }

        private void InitializeChart()
        {
            // Assuming you already have a Chart control named chart1 on your form
            chart1.Series.Clear(); // Clear existing series (if any)

            candlestickSeries = new Series("Candlestick");
            candlestickSeries.ChartType = SeriesChartType.Candlestick;
            candlestickSeries["OpenCloseStyle"] = "Triangle"; // Adjust style as needed
            candlestickSeries["ShowOpenClose"] = "Both"; // Show both open and close prices

            chart1.Series.Add(candlestickSeries);

            // Set the axis range to accommodate the candlesticks
            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisX.Maximum = 5; // Adjust this value based on your data
            chart1.ChartAreas[0].AxisY.Minimum = 0;
            chart1.ChartAreas[0].AxisY.Maximum = 150; // Adjust this value based on your data

            // Add the initial candlestick
            AddCandlestick();
        }
        private void InitializeDatabase()
        {
            // Establish a connection to the database
            string connectionString = "server=127.0.0.1; user=root; database=golddigger; password=";
            connection = new MySqlConnection(connectionString);
        }

        private void AddCandlestick()
        {
            double open = 0;
            double close = 0;
            double high = 0;
            double low = 0;

            DataPoint dataPoint = new DataPoint();
            dataPoint.XValue = currentIndex++;
            dataPoint.YValues = new double[] { high, low, open, close };

            candlestickSeries.Points.Add(dataPoint);
        }


        private void MoveCandlestickUp()
        {
            // Update the close value to simulate moving up
            double newClose = candlestickSeries.Points[currentIndex - 1].YValues[2] + 10; // Adjust the increment as needed
            candlestickSeries.Points[currentIndex - 1].YValues[2] = Math.Min(newClose, MaxCandlestickHeight);

            // Update the chart
            chart1.Invalidate();

            // Check if the current candlestick is full
            if (candlestickSeries.Points[currentIndex - 1].YValues[2] >= MaxCandlestickHeight)
            {
                // Move to the next candlestick if available
                if (currentIndex < chart1.Series[0].Points.Count)
                {
                    currentIndex++;
                }
                else
                {
                    // Add a new candlestick if the next index is within the maximum X-axis value
                    if (currentIndex < chart1.ChartAreas[0].AxisX.Maximum)
                    {
                        AddCandlestick();
                    }
                }
            }
        }

        private void MoveCandlestickDown()
        {
            // Update the close value to simulate moving down
            double newClose = candlestickSeries.Points[currentIndex - 1].YValues[2] - 10; // Adjust the decrement as needed
            candlestickSeries.Points[currentIndex - 1].YValues[2] = Math.Max(newClose, 0);

            // Update the chart
            chart1.Invalidate();

            // Check if the current candlestick is empty
            if (candlestickSeries.Points[currentIndex - 1].YValues[2] <= 0)
            {
                // Move to the previous candlestick if available
                if (currentIndex > 1)
                {
                    currentIndex--;
                }
            }
        }

       

        private void button11_Click(object sender, EventArgs e)
        {
            MoveCandlestickUp();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            MoveCandlestickDown();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string query = "SELECT coin_rate, currency_symbol FROM cryptocurrency";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Assuming you want to display the data in a Label
                        if (dataTable.Rows.Count > 0)
                        {
                            label1.Text = $" {dataTable.Rows[0]["currency_symbol"]} {dataTable.Rows[0]["coin_rate"]}";
                            label2.Text = $" {dataTable.Rows[0]["currency_symbol"]} {dataTable.Rows[0]["coin_rate"]}";
                        }
                        else
                        {
                            label1.Text = "No data found.";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string query = "SELECT coin_rate, currency_symbol FROM cryptocurrency";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Assuming you want to display the data in a Label
                        if (dataTable.Rows.Count > 0)
                        {
                            label1.Text = $" {dataTable.Rows[1]["currency_symbol"]} {dataTable.Rows[1]["coin_rate"]}";
                            label2.Text = $" {dataTable.Rows[1]["currency_symbol"]} {dataTable.Rows[1]["coin_rate"]}";
                        }
                        else
                        {
                            label1.Text = "No data found.";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string query = "SELECT coin_rate, currency_symbol FROM cryptocurrency";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Assuming you want to display the data in a Label
                        if (dataTable.Rows.Count > 0)
                        {
                            label1.Text = $" {dataTable.Rows[2]["currency_symbol"]} {dataTable.Rows[2]["coin_rate"]}";
                            label2.Text = $" {dataTable.Rows[2]["currency_symbol"]} {dataTable.Rows[2]["coin_rate"]}";
                        }
                        else
                        {
                            label1.Text = "No data found.";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string query = "SELECT coin_rate, currency_symbol FROM cryptocurrency";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Assuming you want to display the data in a Label
                        if (dataTable.Rows.Count > 0)
                        {
                            label1.Text = $" {dataTable.Rows[3]["currency_symbol"]} {dataTable.Rows[3]["coin_rate"]}";
                            label2.Text = $" {dataTable.Rows[3]["currency_symbol"]} {dataTable.Rows[3]["coin_rate"]}";
                        }
                        else
                        {
                            label1.Text = "No data found.";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string query = "SELECT coin_rate, currency_symbol FROM cryptocurrency";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Assuming you want to display the data in a Label
                        if (dataTable.Rows.Count > 0)
                        {
                            label1.Text = $" {dataTable.Rows[3]["currency_symbol"]} {dataTable.Rows[3]["coin_rate"]}";
                            label2.Text = $" {dataTable.Rows[3]["currency_symbol"]} {dataTable.Rows[3]["coin_rate"]}";
                        }
                        else
                        {
                            label1.Text = "No data found.";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string query = "SELECT coin_rate, currency_symbol FROM cryptocurrency";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Assuming you want to display the data in a Label
                        if (dataTable.Rows.Count > 0)
                        {
                            label1.Text = $" {dataTable.Rows[5]["currency_symbol"]} {dataTable.Rows[5]["coin_rate"]}";
                            label2.Text = $" {dataTable.Rows[5]["currency_symbol"]} {dataTable.Rows[5]["coin_rate"]}";
                        }
                        else
                        {
                            label1.Text = "No data found.";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string query = "SELECT coin_rate, currency_symbol FROM cryptocurrency";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Assuming you want to display the data in a Label
                        if (dataTable.Rows.Count > 0)
                        {
                            label1.Text = $" {dataTable.Rows[6]["currency_symbol"]} {dataTable.Rows[6]["coin_rate"]}";
                            label2.Text = $" {dataTable.Rows[6]["currency_symbol"]} {dataTable.Rows[6]["coin_rate"]}";
                        }
                        else
                        {
                            label1.Text = "No data found.";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string query = "SELECT coin_rate, currency_symbol FROM cryptocurrency";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Assuming you want to display the data in a Label
                        if (dataTable.Rows.Count > 0)
                        {
                            label1.Text = $" {dataTable.Rows[7]["currency_symbol"]} {dataTable.Rows[7]["coin_rate"]}";
                            label2.Text = $" {dataTable.Rows[7]["currency_symbol"]} {dataTable.Rows[7]["coin_rate"]}";
                        }
                        else
                        {
                            label1.Text = "No data found.";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string query = "SELECT coin_rate, currency_symbol FROM cryptocurrency";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Assuming you want to display the data in a Label
                        if (dataTable.Rows.Count > 0)
                        {
                            label1.Text = $" {dataTable.Rows[8]["currency_symbol"]} {dataTable.Rows[8]["coin_rate"]}";
                            label2.Text = $" {dataTable.Rows[8]["currency_symbol"]} {dataTable.Rows[8]["coin_rate"]}";
                        }
                        else
                        {
                            label1.Text = "No data found.";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string query = "SELECT coin_rate, currency_symbol FROM cryptocurrency";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Assuming you want to display the data in a Label
                        if (dataTable.Rows.Count > 0)
                        {
                            label1.Text = $" {dataTable.Rows[9]["currency_symbol"]} {dataTable.Rows[9]["coin_rate"]}";
                            label2.Text = $" {dataTable.Rows[9]["currency_symbol"]} {dataTable.Rows[9]["coin_rate"]}";
                        }
                        else
                        {
                            label1.Text = "No data found.";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
