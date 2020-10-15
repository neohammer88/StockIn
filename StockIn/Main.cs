/* Title : BMS Stock program
 * Version : 2.0
 * Language : C#
 * Programmer : Tom Rho
 * Date : 27/09/2020
 */

using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;

namespace StockIn
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        public static string user;

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Login login = new Login();
            login.ShowDialog();
            lblUser.Text = Login.user1;
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            user = lblUser.Text;
            Save save = new Save();
            save.Show();
        }

        private void btnStockOut_Click(object sender, EventArgs e)
        {
            user = lblUser.Text;
            Delete delete = new Delete();
            delete.Show();
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            user = lblUser.Text;
            Move move = new Move();
            move.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            user = lblUser.Text;
            Search search = new Search();
            search.Show();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            user = lblUser.Text;
            History history = new History();
            history.Show();
        }

        private void btnBulk_Click(object sender, EventArgs e)
        {
            user = lblUser.Text;
            BulkIn bulkIn = new BulkIn();
            bulkIn.Show();
        }

        //private DataSet GetData()
        //{
        //    string connStr = "Data Source=desktop-v7k5hei\\sqlexpress;Initial Catalog=sql2;Integrated Security=True";
        //    SqlConnection conn = new SqlConnection(connStr);
        //    conn.Open();

        //    DataSet ds = new DataSet();
        //    string sql = "SELECT * FROM Stock";
        //    SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
        //    adapter.Fill(ds);
        //    conn.Close();

        //    return ds;
        //}

        private void btnExcel_Click(object sender, EventArgs e)
        {
            user = lblUser.Text;
            BackupExcel backupExcel = new BackupExcel();
            backupExcel.Show();
        }
    }
}
