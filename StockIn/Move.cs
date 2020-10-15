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
    public partial class Move : Form
    {
        //string connStr = "Data Source=desktop-v7k5hei\\sqlexpress;Initial Catalog=sql2;Integrated Security=True";
        string connStr = "Data Source=BMSDC;Initial Catalog=STOCKLOCATOR;User=stocklocator; Password=BMS1234";
        DataTable dt = new DataTable();
        SqlConnection conn;
        SqlDataAdapter adapt;

        public Move()
        {
            InitializeComponent();
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            string user2 = lblUser.Text;
            //Check the locations
            if (string.IsNullOrEmpty(txtBoxMoveFromLocation.Text) && string.IsNullOrEmpty(txtBoxMoveToLocation.Text))
            {
                MessageBox.Show("Input Locations!", "ERROR", MessageBoxButtons.OK);
                return;
            }
            else
            {
                try
                {
                    string stateMove = "Move";
                    //Update location information of selected stocks
                    foreach (DataGridViewRow row in dataGridViewMove.Rows)
                    {
                        using (SqlConnection conn = new SqlConnection(connStr))
                        {
                            conn.Open();
                            using (SqlCommand cmd = new SqlCommand("INSERT INTO History (BMSNo, Location, Date, [User], State) VALUES (@bms, @location, getdate(), @user2, @state); UPDATE Stock SET Location = @location, Date = getdate(), [User] = @user2 WHERE BMSNo = '" + row.Cells[0].Value.ToString() + "'", conn))
                            {
                                //cmd.Parameters.AddWithValue("@id", txtId.Text);
                                cmd.Parameters.AddWithValue("@bms", (row.Cells[0].Value));
                                cmd.Parameters.AddWithValue("@location", txtBoxMoveToLocation.Text.ToString());
                                cmd.Parameters.AddWithValue("@date", dateTimePickerMove.Value);
                                cmd.Parameters.AddWithValue("@user2", lblUser.Text.ToString());
                                cmd.Parameters.AddWithValue("@state", stateMove);
                                //if (!(string.IsNullOrEmpty(txtBmsNo3.Text)))
                                cmd.ExecuteNonQuery();
                                conn.Close();
                            }
                        }
                    }
                    MessageBox.Show("Move Success!", "MOVE", MessageBoxButtons.OK);

                    //Show the updated location of stocks after moving
                    DataTable dt = new DataTable();
                    conn = new SqlConnection(connStr);
                    conn.Open();
                    adapt = new SqlDataAdapter("select * from Stock where Location like '" + txtBoxMoveToLocation.Text + "%'", conn);
                    adapt.Fill(dt);
                    dataGridViewMove.DataSource = dt;
                    conn.Close();
                    txtBoxMoveToCount_TextChanged(sender, e);
                    txtBoxMoveFromCount_TextChanged(sender, e);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                    //txtBoxFrom.Text = "";
                    //txtBoxTo.Text = "";
                }
            }
        }

        private void Move_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sTOCKLOCATORDataSet.Stock' table. You can move, or remove it, as needed.
            this.stockTableAdapter.Fill(this.sTOCKLOCATORDataSet.Stock);
            // TODO: This line of code loads data into the 'sql2DataSet.Stock' table. You can move, or remove it, as needed.
            //this.stockTableAdapter.Fill(this.masterDataSet.Stock);
            pBoxArrow.BorderStyle = BorderStyle.None;

            lblUser.Text = Main.user;
            //dt.Columns.Add("BMSNo");
            //dt.Columns.Add("Location");
            //dt.Columns.Add("Date");

            dateTimePickerMove.Value = DateTime.Now;
            dataGridViewMove.DataSource = dt;
            this.dataGridViewMove.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.ActiveControl = txtBoxMoveFromLocation;
        }

        private void btnMoveExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtBoxMoveFromLocation_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                conn = new SqlConnection(connStr);
                conn.Open();
                adapt = new SqlDataAdapter("select * from Stock where Location like '" + txtBoxMoveFromLocation.Text + "%'", conn);
                adapt.Fill(dt);
                dataGridViewMove.DataSource = dt;
                conn.Close();
                txtBoxMoveFromCount_TextChanged(sender, e);
                this.ActiveControl = txtBoxMoveToLocation;
            }
        }

        private void txtBoxMoveFromCount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connStr);
                string sum = "SELECT COUNT(*) FROM Stock WHERE Location = '" + txtBoxMoveFromLocation.Text + "'";
                SqlCommand cmd = new SqlCommand(sum, conn);
                conn.Open();
                object locationSum1 = cmd.ExecuteScalar();
                if (locationSum1 != null)
                {
                    txtBoxMoveFromCount.Text = locationSum1.ToString();
                }
                else
                {
                    MessageBox.Show("No stocks in the location", "ERROR", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void txtBoxMoveToCount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connStr);
                string sum = "SELECT COUNT(*) FROM Stock WHERE Location = '" + txtBoxMoveToLocation.Text + "'";
                SqlCommand cmd = new SqlCommand(sum, conn);
                conn.Open();
                object locationSum2 = cmd.ExecuteScalar();
                if (locationSum2 != null)
                {
                    txtBoxMoveToCount.Text = locationSum2.ToString();
                }
                else
                {
                    MessageBox.Show("No stocks in the location", "ERROR", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void txtBoxMoveToLocation_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                btnMove_Click(sender, e);
            }
        }
    }
}
