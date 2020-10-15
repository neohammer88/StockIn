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
    public partial class History : Form
    {
        //string connStr = "Data Source=desktop-v7k5hei\\sqlexpress;Initial Catalog=sql2;Integrated Security=True";
        string connStr = "Data Source=BMSDC;Initial Catalog=STOCKLOCATOR;User=stocklocator; Password=BMS1234";
        DataTable dt = new DataTable();
        SqlConnection conn;
        SqlDataAdapter adapt;

        public History()
        {
            InitializeComponent();
        }

        private void History_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sTOCKLOCATORDataSet.History' table. You can move, or remove it, as needed.
            this.historyTableAdapter.Fill(this.sTOCKLOCATORDataSet.History);
            // TODO: This line of code loads data into the 'sTOCKLOCATORDataSet.History' table. You can move, or remove it, as needed.
            //this.historyTableAdapter1.Fill(this.sTOCKLOCATORDataSet.History);
            // TODO: This line of code loads data into the 'sql2DataSet.History' table. You can move, or remove it, as needed.
            //this.historyTableAdapter.Fill(this.masterDataSet.History);
            // TODO: This line of code loads data into the 'sql2DataSet.Stock' table. You can move, or remove it, as needed.
            //this.stockTableAdapter.Fill(this.masterDataSet.Stock);

            lblUser.Text = Main.user;
            dataGridViewHistory.DataSource = dt;
            this.dataGridViewHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.ActiveControl = dateTimePickerHistoryFrom;
        }

        private void btnHistorySearch_Click(object sender, EventArgs e)
        {
            try
            {
                //Show the updated location of stocks after moving
                conn = new SqlConnection(connStr);
                DataTable dt = new DataTable();
                adapt = new SqlDataAdapter("select * from History where [Date] BETWEEN '" + dateTimePickerHistoryFrom.Value.Date.ToShortDateString() + "' AND '" +dateTimePickerHistoryTo.Value.Date.ToShortDateString() + "'", conn);
                adapt.Fill(dt);
                dataGridViewHistory.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHistoryExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnHistoryDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Do you really want to delete History of the selected period?", "CONFIRM", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    //string date = dtpHistory.Text;
                    conn = new SqlConnection(connStr);
                    string delete = "DELETE FROM History Where [Date] BETWEEN @date AND @date2"/* + dtpHistory.Text + "'"*/;
                    SqlCommand cmd = new SqlCommand(delete, conn);
                    cmd.Parameters.AddWithValue("@date", dateTimePickerHistoryFrom.Value.Date);
                    cmd.Parameters.AddWithValue("@date2", dateTimePickerHistoryTo.Value.Date);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    dataGridViewHistory.DataSource = "null";
                    conn.Close();
                    MessageBox.Show("Delete History Succeed!");
                    //this.Close();
                }
                else if (dialogResult == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
