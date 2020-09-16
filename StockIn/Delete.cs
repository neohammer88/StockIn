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
        string connStr = "Data Source=desktop-v7k5hei\\sqlexpress;Initial Catalog=sql2;Integrated Security=True";
        //SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapt;
        SqlDataReader rd;

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
            lblUser.Text = Main.user;

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
                btnDelete_Click(sender, e);
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

            if (string.IsNullOrEmpty(txtBoxDeleteBMSNo.Text))
            {
                MessageBox.Show("Please Input BMS No.!", "ERROR", MessageBoxButtons.OK);
                return;
            }

            try
            {
                string stateDelete = "Delete";
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
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO History (BMSNo, Location, Date, [User], State) VALUES (@bms, @location, getdate(), @user2, @state); DELETE FROM Stock WHERE BMSNo = '" + newStock.BMSNo + "'", conn))
                    {
                        cmd.Parameters.AddWithValue("@bms", newStock.BMSNo);
                        cmd.Parameters.AddWithValue("@location", newStock.Location);
                        cmd.Parameters.AddWithValue("@date", dtPickerDelete.Text.ToString());
                        cmd.Parameters.AddWithValue("@user2", newStock.User);
                        cmd.Parameters.AddWithValue("@state", stateDelete);

                        cmd.ExecuteNonQuery();
                        //dataGridView3.Rows.RemoveAt(row.Index);
                        conn.Close();
                    }
                    //txtBmsNo3.Text = "";
                }

                //if the stock is new, input it to database
                else
                {
                    MessageBox.Show("No stocks in Database", "ERROR", MessageBoxButtons.OK);
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
                txtBoxDeleteBMSNo.Text = "";
                //datePicker3.Value = DateTime.Now;
            }
        }

    }
}
