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
    public partial class Admin : Form
    {
        //string connStr = "Data Source=desktop-v7k5hei\\sqlexpress;Initial Catalog=sql2;Integrated Security=True";
        string connStr = "Data Source=BMSDC;Initial Catalog=STOCKLOCATOR;User=stocklocator; Password=BMS1234";
        SqlConnection conn;

        public Admin()
        {
            InitializeComponent();
        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            string admin, adminPassword;
            admin = txtBoxAdminID.Text;
            adminPassword = txtBoxAdminPW.Text;

            if (admin == "admin" && adminPassword == "bmsit2014")
            {
                DialogResult dialogResult = MessageBox.Show("Do you really want to delete all?", "CONFIRM", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    conn = new SqlConnection(connStr);
                    conn.Open();
                    string stateDeleteAll = "Delete All";
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO History (BMSNo, Location, Date, [User], State) VALUES (@bms, @location, getdate(), @user2, @state); DELETE FROM Stock", conn))
                    {
                        cmd.Parameters.AddWithValue("@bms", admin);
                        cmd.Parameters.AddWithValue("@location", admin);
                        cmd.Parameters.AddWithValue("@user2", admin);
                        cmd.Parameters.AddWithValue("@state", stateDeleteAll);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("DELETE ALL");
                        this.Close();
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else
            {
                this.Hide();
                MessageBox.Show("WRONG USER!");
                Admin adminForm  = new Admin();
                adminForm.Show();
            }
        }

        private void btnAdminExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtBoxAdminPW_TextChanged(object sender, EventArgs e)
        {
            txtBoxAdminPW.PasswordChar = '*';
        }
    }
}
