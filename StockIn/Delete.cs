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
    public partial class Delete : Form
    {
        //string connStr = "Data Source=desktop-v7k5hei\\sqlexpress;Initial Catalog=sql2;Integrated Security=True";
        string connStr = "Data Source=BMSDC;Initial Catalog=STOCKLOCATOR;User=stocklocator; Password=BMS1234";
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapt;
        SqlDataReader rd;
        DataTable dt = new DataTable();

        struct Stock
        {
            public string BMSNo;
            public string Location;
            public DateTime GetDateTime;
            public string User;
        }

        public Delete()
        {
            InitializeComponent();
        }

        private void Delete_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sTOCKLOCATORDataSet.Stock' table. You can move, or remove it, as needed.
            this.stockTableAdapter.Fill(this.sTOCKLOCATORDataSet.Stock);
            // TODO: This line of code loads data into the 'sql2DataSet.Stock' table. You can move, or remove it, as needed.
            //this.stockTableAdapter.Fill(this.masterDataSet.Stock);
            lblUser.Text = Main.user;
            dataGridViewDelete.DataSource = dt;

            dtPickerDelete.Value = DateTime.Now;
            this.ActiveControl = txtBoxDeleteBMSNo;
        }

        private void btnDeleteExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtBoxDeleteBMSNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                if (string.IsNullOrEmpty(txtBoxDeleteBMSNo.Text))
                {
                    MessageBox.Show("Please Input BMS No.!", "ERROR", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    try
                    {
                        conn = new SqlConnection(connStr);
                        string exist = "SELECT COUNT(*) FROM Stock WHERE BMSNo = '" + txtBoxDeleteBMSNo.Text + "'";
                        SqlCommand cmd = new SqlCommand(exist, conn);
                        conn.Open();
                        int userExist = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                        //If the stock is in databse, show it to datagridview
                        if (userExist > 0)
                        {
                            adapt = new SqlDataAdapter("select * from Stock where BMSNo = '" + txtBoxDeleteBMSNo.Text + "'", conn);

                            adapt.Fill(dt);
                            dataGridViewDelete.DataSource = dt;
                            conn.Close();
                        }
                        //If the stock is not in database, show the error message
                        else
                        {
                            //System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                            //player.SoundLocation = @"C:\sample1.wav";
                            //player.Load();
                            //player.Play();
                            MessageBox.Show(txtBoxDeleteBMSNo.Text + "\n is Not in DB!", "Warning", MessageBoxButtons.OK);
                            return;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        txtBoxDeleteBMSNo.Text = "";
                        conn.Close();
                    }
                btnDelete_Click(sender, e);
                }
            }
        }

        private void txtBoxLocationCount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connStr);
                string sum = "SELECT COUNT(*) FROM Stock WHERE Location = '" + txtBoxDeleteLocation.Text + "'";
                SqlCommand cmd = new SqlCommand(sum, conn);
                conn.Open();
                object locationSum = cmd.ExecuteScalar();
                if (locationSum != null)
                    txtBoxLocationCount.Text = locationSum.ToString();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtBoxDeleteLocation_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                txtBoxLocationCount_TextChanged(sender, e);
                this.ActiveControl = btnDelete;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Stock newStock;
            newStock.BMSNo = txtBoxDeleteBMSNo.Text;
            newStock.Location = txtBoxDeleteLocation.Text;
            newStock.User = lblUser.Text;

            //if (string.IsNullOrEmpty(txtBoxDeleteBMSNo.Text))
            //{
            //    MessageBox.Show("Please Input BMS No.!", "ERROR", MessageBoxButtons.OK);
            //    return;
            //}
            //else
            //{
                try
                {
                    string stateDelete = "Delete";
                    //Update location information of selected stocks
                    foreach (DataGridViewRow row in dataGridViewDelete.Rows)
                    {
                        using (SqlConnection conn2 = new SqlConnection(connStr))
                        {
                            conn2.Open();
                            using (SqlCommand cmd = new SqlCommand("INSERT INTO History (BMSNo, Location, Date, [User], State) VALUES (@bms, @location, getdate(), @user2, @state); DELETE FROM Stock WHERE BMSNo = '" + row.Cells[0].Value.ToString() + "'", conn2))
                            {
                                cmd.Parameters.AddWithValue("@bms", row.Cells[0].Value);
                                cmd.Parameters.AddWithValue("@location", row.Cells[1].Value);
                                //cmd.Parameters.AddWithValue("@date", dtPickerDelete.Text.ToString());
                                cmd.Parameters.AddWithValue("@user2", newStock.User);
                                cmd.Parameters.AddWithValue("@state", stateDelete);

                                cmd.ExecuteNonQuery();
                                dt.Clear();
                                dataGridViewDelete.Refresh();
                                conn2.Close();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    txtBoxDeleteBMSNo.Text = "";
                    //conn.Close();
                    //datePicker3.Value = DateTime.Now;
                }
            //}
        }

        private void btnDeleteAllStock_Click(object sender, EventArgs e)
        {
            Admin adminForm = new Admin();
            adminForm.Show();
        }
    }
}
