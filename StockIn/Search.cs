/* Title : BMS Stock program
 * Version : 2.0
 * Language : C#
 * Programmer : Tom Rho
 * Date : 27/09/2020
 */

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

namespace StockIn
{
    public partial class Search : Form
    {
        //string connStr = "Data Source=desktop-v7k5hei\\sqlexpress;Initial Catalog=sql2;Integrated Security=True";
        string connStr = "Data Source=BMSDC;Initial Catalog=STOCKLOCATOR;User=stocklocator; Password=BMS1234";
        DataTable dt = new DataTable();
        SqlConnection conn;
        SqlDataAdapter adapt;

        public Search()
        {
            InitializeComponent();
        }

        private void Search_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sql2DataSet.Stock' table. You can move, or remove it, as needed.
            //this.stockTableAdapter.Fill(this.masterDataSet.Stock);

            lblUser.Text = Main.user;
            dataGridViewSearch.DataSource = dt;
            this.dataGridViewSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.ActiveControl = txtBoxSearchBMSNo;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Check the BMS No.
            if (string.IsNullOrEmpty(txtBoxSearchBMSNo.Text))
            {
                MessageBox.Show("Input BMS No.!", "ERROR", MessageBoxButtons.OK);
                return;
            }
            else
            {
                try
                {
                    //Check the duplicate in database
                    conn = new SqlConnection(connStr);
                    conn.Open();
                    SqlCommand exist = new SqlCommand("SELECT COUNT(*) FROM Stock WHERE ([BMSNo] = @bms)", conn);
                    exist.Parameters.AddWithValue("@bms", txtBoxSearchBMSNo.Text.ToString());
                    int stockExist = (int)exist.ExecuteScalar();
                    //if there is the duplicate in database, update information of each stock
                    if (stockExist > 0)
                    {
                        //Show the updated location of stocks after moving
                        DataTable dt = new DataTable();
                        adapt = new SqlDataAdapter("select * from Stock where BMSNo like '" + txtBoxSearchBMSNo.Text + "%'", conn);
                        adapt.Fill(dt);
                        dataGridViewSearch.DataSource = dt;
                        conn.Close();
                    }
                    //if the stock is new, input it to database
                    else
                    {
                        MessageBox.Show("No stocks in Database", "ERROR", MessageBoxButtons.OK);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    txtBoxSearchBMSNo.Text = "";
                    conn.Close();
                }
            }
        }

        private void txtBoxSearchBMSNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                btnSearch_Click(sender, e);
                this.ActiveControl = txtBoxSearchBMSNo;
            }
        }

        private void btnSearchExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
