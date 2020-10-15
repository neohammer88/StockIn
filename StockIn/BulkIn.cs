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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockIn
{
    public partial class BulkIn : Form
    {
        //string connStr = "Data Source=desktop-v7k5hei\\sqlexpress;Initial Catalog=sql2;Integrated Security=True";
        string connStr = "Data Source=BMSDC;Initial Catalog=STOCKLOCATOR;User=stocklocator; Password=BMS1234";
        DataTable dt = new DataTable();
        SqlConnection conn;

        public BulkIn()
        {
            InitializeComponent();
        }

        private void BulkIn_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sTOCKLOCATORDataSet.Stock' table. You can move, or remove it, as needed.
            this.stockTableAdapter.Fill(this.sTOCKLOCATORDataSet.Stock);
            // TODO: This line of code loads data into the 'sql2DataSet.Stock' table. You can move, or remove it, as needed.
            //this.stockTableAdapter.Fill(this.masterDataSet.Stock);
            dt.Columns.Add("BMSNo");
            dt.Columns.Add("Location");
            dt.Columns.Add("Date");
            dt.Columns.Add("User");

            lblUser.Text = Main.user;
            dataGridViewBulk.DataSource = dt;
            dateTimePickerBulk.Value = DateTime.Now;
            this.ActiveControl = txtBoxBulkLocation;
            this.dataGridViewBulk.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void btnBulkExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnBulkList_Click(object sender, EventArgs e)
        {
            string bms = txtBoxBulkStartNo.Text;
            string bmsNo = Regex.Replace(bms, @"\D", "");
            string location = txtBoxBulkLocation.Text;
            string user2 = lblUser.Text;

            try
            {
                if (string.IsNullOrEmpty(txtBoxBulkStartNo.Text))
                {
                    MessageBox.Show("Please Input BMS No.!", "ERROR", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    for (int i = 0; i < Convert.ToInt32(txtBoxBulkCount.Text); i++)
                    {
                        DataRow dr = dt.NewRow();
                        dr["BMSNo"] = txtBoxBulkTitle.Text.ToString() + (Convert.ToInt32(bmsNo) + (Convert.ToInt32(i)));
                        dr["Location"] = txtBoxBulkLocation.Text;
                        dr["Date"] = dateTimePickerBulk.Value.Date;
                        dr["User"] = lblUser.Text;
                        dt.Rows.Add(dr);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtBoxBulkCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                btnBulkList_Click(sender, e);
            }
        }

        private void btnBulkSave_Click(object sender, EventArgs e)
        {
            if (dataGridViewBulk.Rows.Count == 0)
            {
                MessageBox.Show("Please Input BMSNo. first!", "ERROR", MessageBoxButtons.OK);
                return;
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Do you really want to save all stocks?", "CONFIRM", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        string stateUpdate = "Update";
                        string stateSave = "Save";

                        foreach (DataGridViewRow row in dataGridViewBulk.Rows)
                        {
                            using (SqlConnection conn = new SqlConnection(connStr))
                            {
                                SqlCommand exist = new SqlCommand("SELECT COUNT(*) FROM Stock WHERE ([BMSNo] = @bms)", conn);
                                exist.Parameters.AddWithValue("@bms", (row.Cells[0].Value));
                                conn.Open();
                                int userExist = (int)exist.ExecuteScalar();

                                if (userExist > 0)
                                {
                                    using (SqlCommand cmd = new SqlCommand("INSERT INTO History (BMSNo, Location, Date, [User], State) VALUES (@bms, @location, getdate(), @user2, @state); UPDATE Stock SET Location = @location, Date = getdate(), [User] = @user2 WHERE BMSNo = '" + txtBoxBulkStartNo.Text + "'", conn))
                                    {
                                        cmd.Parameters.AddWithValue("@bms", (row.Cells[0].Value));
                                        cmd.Parameters.AddWithValue("@location", (row.Cells[1].Value));
                                        cmd.Parameters.AddWithValue("@user2", (row.Cells[2].Value));
                                        cmd.Parameters.AddWithValue("@state", stateUpdate);

                                        //conn.Open();
                                        cmd.ExecuteNonQuery();
                                        conn.Close();
                                    }
                                }
                                else
                                {
                                    using (SqlCommand cmd = new SqlCommand("INSERT INTO History (BMSNo, Location, Date, [User], State) VALUES (@bms, @location, getdate(), @user2, @state); INSERT INTO Stock (BMSNo, Location, Date, [User]) VALUES (@bms, @location, getdate(), @user2)", conn))
                                    {
                                        cmd.Parameters.AddWithValue("@bms", (row.Cells[0].Value));
                                        cmd.Parameters.AddWithValue("@location", (row.Cells[1].Value));
                                        cmd.Parameters.AddWithValue("@user2", (row.Cells[2].Value));
                                        cmd.Parameters.AddWithValue("@state", stateSave);

                                        //conn.Open();
                                        cmd.ExecuteNonQuery();
                                        conn.Close();
                                    }
                                }
                                conn.Close();
                            }
                        }
                        MessageBox.Show("Save Success!", "SAVE", MessageBoxButtons.OK);
                        //btnCancel9_Click(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        //conn.Close();
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }
        }
    }
}
