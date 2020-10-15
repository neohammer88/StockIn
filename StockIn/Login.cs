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
    public partial class Login : Form
    {

        //string connStr = "Data Source=desktop-v7k5hei\\sqlexpress;Initial Catalog=sql2;Integrated Security=True";
        string connStr = "Data Source=BMSDC;Initial Catalog=STOCKLOCATOR;User=stocklocator; Password=BMS1234";
        DataTable dt = new DataTable();
        SqlConnection conn;
        SqlDataAdapter adapt;

        public Login()
        {
            InitializeComponent();
        }

        public static string user1;

        struct MemberStruct
        {
            public string Name;
            public string Password;
        }

        private void btnLoginExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            user1 = txtBoxID.Text;

            try
            {
                string memberQuery = "SELECT * FROM Member WHERE [Name]= @member AND [Password]= @password"/* '" + txtBoxID.Text + "'"*/;
                SqlConnection conn = new SqlConnection(connStr);
                SqlCommand cmd = new SqlCommand(memberQuery, conn);
                cmd.Parameters.AddWithValue("@member", txtBoxID.Text.ToString());
                cmd.Parameters.AddWithValue("@password", txtBoxPW.Text.ToString());
                //SqlDataReader dbr;
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    //MessageBox.Show("Welcome!");
                    this.Hide();
                    Main main = new Main();
                }
                else
                {
                    MessageBox.Show("Wrong User!");
                }
                conn.Close();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void txtBoxPW_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                btnLogin_Click(sender, e);
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void txtBoxPW_TextChanged(object sender, EventArgs e)
        {
            txtBoxPW.PasswordChar = '*';
        }

        private void btnRegistMember_Click(object sender, EventArgs e)
        {
            MemberStruct newMember;
            newMember.Name = txtBoxID.Text;
            newMember.Password = txtBoxPW.Text;
            try
            {
                string memberQuery = "SELECT * FROM Member WHERE [Name]= @member AND [Password]= @password"/* '" + txtBoxID.Text + "'"*/;
                SqlConnection conn = new SqlConnection(connStr);
                SqlCommand cmd = new SqlCommand(memberQuery, conn);
                cmd.Parameters.AddWithValue("@member", txtBoxID.Text.ToString());
                cmd.Parameters.AddWithValue("@password", txtBoxPW.Text.ToString());
                //SqlDataReader dbr;
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("[ " + newMember.Name + " ] are already registered!", "ERROR", MessageBoxButtons.OK);
                }
                else if (string.IsNullOrEmpty(newMember.Name))
                {
                    DialogResult dialogResult = MessageBox.Show("Please Input Name!", "ERROR", MessageBoxButtons.OK);
                }
                else if (newMember.Password != "1234")
                {
                    DialogResult dialogResult = MessageBox.Show("Please Input Password again!", "ERROR", MessageBoxButtons.OK);
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Do you really want to regist a new Member?", "CONFIRM", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        using (SqlCommand cmdNew = new SqlCommand("INSERT INTO Member ([Name], Password) VALUES (@newMember, @password)", conn))
                        {
                            cmdNew.Parameters.AddWithValue("@newMember", newMember.Name);
                            cmdNew.Parameters.AddWithValue("@password", newMember.Password);
                            cmdNew.ExecuteNonQuery();
                            MessageBox.Show("Welcome New Member!", "Success", MessageBoxButtons.OK);
                            conn.Close();
                        }
                    }
                }
                conn.Close();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }
    }
}
