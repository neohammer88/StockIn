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
    public partial class Save : Form
    {

        string connStr = "Data Source=desktop-v7k5hei\\sqlexpress;Initial Catalog=sql2;Integrated Security=True";
        //SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapt;
        SqlDataReader rd;

        public Save()
        {
            InitializeComponent();
        }

        struct Stock
        {
            public string BMSNo;
            public string Location;
            public DateTime GetDateTime;
            public string User;
        }

        private void Save_Load(object sender, EventArgs e)
        {
            //SqlConnection conn = new SqlConnection(connStr);
            //string query = "SELECT Name FROM Member WHERE [Name] = @name";
            //SqlCommand cmd = new SqlCommand(query, conn);
            //conn.Open();
            //cmd.Parameters.AddWithValue("@name", lblUser.Text);

            lblUser.Text = Main.user;

            dtPickerSaveTime.Value = DateTime.Now;
            this.ActiveControl = txtBoxSaveLocation;
            //this.ActiveControl = txtBmsNo3;
            //txtBoxSum_TextChanged(sender, e);
            //conn.Close();
        }

        private void btnSaveExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Stock newStock;
            newStock.BMSNo = txtBoxSaveBMSNo.Text;
            newStock.Location = txtBoxSaveLocation.Text;
            newStock.User = lblUser.Text;

            if (string.IsNullOrEmpty(txtBoxSaveBMSNo.Text))
            {
                MessageBox.Show("Please Input BMS No.!", "ERROR", MessageBoxButtons.OK);
                return;
            }

            try
            {
                string stateUpdate = "Update";
                string stateInsert = "Save";
                SqlConnection conn = new SqlConnection(connStr);
                //Check the duplicate in database
                SqlCommand exist = new SqlCommand("SELECT COUNT(*) FROM Stock WHERE ([BMSNo] = @bms)", conn);
                exist.Parameters.AddWithValue("@bms", newStock.BMSNo);
                conn.Open();
                int stockExist = (int)exist.ExecuteScalar();
                //if there is the duplicate in database, update information of each stock
                if (stockExist > 0)
                {
                    //System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                    //player.SoundLocation = @"C:\sample1.wav";
                    //player.Load();
                    //player.Play();
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO History (BMSNo, Location, Date, [User], State) VALUES (@bms, @location, getdate(), @user2, @state); UPDATE Stock SET Location = @location, Date = getdate(), [User] = @user2 WHERE BMSNo = '" + newStock.BMSNo + "'", conn))
                    {
                        cmd.Parameters.AddWithValue("@bms", newStock.BMSNo);
                        cmd.Parameters.AddWithValue("@location", newStock.Location);
                        cmd.Parameters.AddWithValue("@date", dtPickerSaveTime.Text.ToString());
                        cmd.Parameters.AddWithValue("@user2", newStock.User);
                        cmd.Parameters.AddWithValue("@state", stateUpdate);

                        cmd.ExecuteNonQuery();
                        //dataGridView3.Rows.RemoveAt(row.Index);
                        conn.Close();
                    }
                    //txtBmsNo3.Text = "";
                }

                //if the stock is new, input it to database
                else
                {
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO History (BMSNo, Location, Date, [User], State) VALUES (@bms, @location, getdate(), @user2, @state); INSERT INTO Stock (BMSNo, Location, Date, [User]) VALUES (@bms, @location, getdate(), @user2)", conn))
                    {
                        //if (row.Cells["BMSNo"].Value == null || row.Cells["Location"].Value == null || row.Cells["Date"].Value == null||row.Cells["User"].Value == null)
                        //{
                        //    row.Cells["BMSNo"].Value = DBNull.Value;
                        //    row.Cells["Location"].Value = DBNull.Value;
                        //    row.Cells["Date"].Value = DBNull.Value;
                        //    row.Cells["User"].Value = DBNull.Value;
                        //}
                        cmd.Parameters.AddWithValue("@bms", newStock.BMSNo);
                        cmd.Parameters.AddWithValue("@location", newStock.Location);
                        cmd.Parameters.AddWithValue("@date", dtPickerSaveTime.Text.ToString());
                        cmd.Parameters.AddWithValue("@user2", newStock.User);
                        cmd.Parameters.AddWithValue("@state", stateInsert);

                        cmd.ExecuteNonQuery();
                        //dataGridView3.Rows.RemoveAt(row.Index);
                        conn.Close();
                    }
                }
                //}
                //}
                conn.Close();
                //                MessageBox.Show("Save Success!", "SAVE", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                txtBoxSaveBMSNo.Text = "";
                //datePicker3.Value = DateTime.Now;
            }
        }

        private void txtBoxSaveBMSNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                btnSave_Click(sender, e);
                txtBoxSaveSum_TextChanged(sender, e);
            }
        }

        private void txtBoxSaveSum_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connStr);
                string sum = "SELECT COUNT(*) FROM Stock WHERE Location = '" + txtBoxSaveLocation.Text + "'";
                SqlCommand cmd = new SqlCommand(sum, conn);
                conn.Open();
                object locationSum = cmd.ExecuteScalar();
                if (locationSum != null)
                    txtBoxSaveSum.Text = locationSum.ToString();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtBoxSaveLocation_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                txtBoxSaveSum_TextChanged(sender, e);
                this.ActiveControl = txtBoxSaveBMSNo;
            }
        }
    }
}
