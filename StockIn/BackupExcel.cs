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
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data.OleDb;

namespace StockIn
{
    public partial class BackupExcel : Form
    {
        //string connStr = "Data Source=desktop-v7k5hei\\sqlexpress;Initial Catalog=sql2;Integrated Security=True";
        string connStr = "Data Source=BMSDC;Initial Catalog=STOCKLOCATOR;User=stocklocator; Password=BMS1234";

        public BackupExcel()
        {
            InitializeComponent();
        }

        private DataSet GetData()
        {
            //string connStr = "Data Source=desktop-v7k5hei\\sqlexpress;Initial Catalog=sql2;Integrated Security=True";
            string connStr = "Data Source=BMSDC:1433;Initial Catalog=STOCKLOCATOR;User=stocklocator; Password=BMS1234";
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();

            DataSet ds = new DataSet();
            string sql = "SELECT * FROM Stock";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            adapter.Fill(ds);
            conn.Close();

            return ds;
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {

        }

        private void btnBackupToExcelFile_Click(object sender, EventArgs e)
        {
            try
            {
                // Call Data
                DataSet ds = GetData();
                Excel.Application ap = new Excel.Application();
                Excel.Workbook excelWorkBook = ap.Workbooks.Add();

                //Put Data to Excel
                foreach (DataTable dt in ds.Tables)
                {
                    Excel.Worksheet ws = excelWorkBook.Sheets.Add();
                    ws.Name = dt.TableName;

                    //Input Header Name in Excel
                    for (int columnHeaderIndex = 1; columnHeaderIndex <= dt.Columns.Count; columnHeaderIndex++)
                    {
                        ws.Cells[1, columnHeaderIndex] = dt.Columns[columnHeaderIndex - 1].ColumnName;
                        ws.Cells[1, columnHeaderIndex].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.LightSteelBlue);
                    }

                    //Input every data of DataSet
                    for (int rowIndex = 0; rowIndex <= (dt.Rows.Count - 1); rowIndex++)
                    {
                        for (int columnIndex = 0; columnIndex < dt.Columns.Count; columnIndex++)
                        {
                            ws.Cells[rowIndex + 2, columnIndex + 1] = dt.Rows[rowIndex].ItemArray[columnIndex].ToString();
                        }
                    }
                    //Adjust the column width automatically
                    ws.Columns.AutoFit();
                }

                //Make a file with extension and saving directory
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
                saveFile.Title = "File Saving";
                saveFile.DefaultExt = "xlsx";
                saveFile.Filter = "Xlsx files(*.xlsx)|*.xlsx|Xls files(*.xls)|*.xls";
                saveFile.ShowDialog();

                if (saveFile.FileNames.Length > 0)
                {
                    foreach (string filename in saveFile.FileNames)
                    {
                        string savePath = filename;
                        if (Path.GetExtension(savePath) == ".xls")
                        {
                            excelWorkBook.SaveAs(savePath, Excel.XlFileFormat.xlWorkbookNormal);
                        }
                        else if (Path.GetExtension(savePath) == ".xlsx")
                        {
                            excelWorkBook.SaveAs(savePath, Excel.XlFileFormat.xlOpenXMLWorkbook);
                        }
                        excelWorkBook.Close(true);
                        ap.Quit();
                    }
                    MessageBox.Show("Saved!", "SUCCESS", MessageBoxButtons.OK);
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnBackupExcelExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BackupExcel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sTOCKLOCATORDataSet.Stock' table. You can move, or remove it, as needed.
            this.stockTableAdapter.Fill(this.sTOCKLOCATORDataSet.Stock);
            // TODO: This line of code loads data into the 'sql2DataSet.Stock' table. You can move, or remove it, as needed.
            //this.stockTableAdapter.Fill(this.masterDataSet.Stock);
            lblUser.Text = Main.user;
        }

        private void btnRestoreFromExcel_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "xlsx files (*.xlsx)|*.xlsx|Xls files(*.xls)|*.xls";
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
                openFileDialog.Title = "Select a Excel file";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ImportExcelFile(openFileDialog.FileName);
                    MessageBox.Show("Restored!", "SUCCESS", MessageBoxButtons.OK);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ImportExcelFile(string sFilePath)
        {
            String name = "Table"; //Name of your Sheet in the work book
            String constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
                            sFilePath +
                            ";Extended Properties='Excel 12.0 XML;HDR=YES;';";

            OleDbConnection Connection = new OleDbConnection(constr);
            OleDbCommand OleConnection = new OleDbCommand("SELECT * FROM [" + name + "$]", Connection);
            Connection.Open();

            OleDbDataAdapter sda = new OleDbDataAdapter(OleConnection);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridViewRestoreExcel.DataSource = dt;

            try
            {
                string stateRestore = "Restore";
                //Update location information of selected stocks
                foreach (DataGridViewRow row in dataGridViewRestoreExcel.Rows)
                {
                    using (SqlConnection conn3 = new SqlConnection(connStr))
                    {
                        conn3.Open();
                        using (SqlCommand cmd = new SqlCommand("INSERT INTO History (BMSNo, Location, Date, [User], State) VALUES (@bms, @location, getdate(), @user2, @state); INSERT INTO Stock (BMSNo, Location, Date, [User]) VALUES (@bms, @location, getdate(), @user2)", conn3))
                        {
                            cmd.Parameters.AddWithValue("@bms", row.Cells[0].Value);
                            cmd.Parameters.AddWithValue("@location", row.Cells[1].Value);
                            //cmd.Parameters.AddWithValue("@date", dtPickerDelete.Text.ToString());
                            cmd.Parameters.AddWithValue("@user2", lblUser.Text);
                            cmd.Parameters.AddWithValue("@state", stateRestore);

                            cmd.ExecuteNonQuery();
                            //dt.Clear();
                            //dataGridViewRestoreExcel.Refresh();
                            conn3.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
