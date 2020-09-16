using System;
using System.Windows.Forms;

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
    }
}
