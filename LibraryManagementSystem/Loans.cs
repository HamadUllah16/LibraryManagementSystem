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

namespace LibraryManagementSystem
{
    public partial class Loans : Form
    {
        public Loans()
        {
            InitializeComponent();
            dataBinding.Database db = new dataBinding.Database();

            string query = "SELECT * FROM Loan";

            SqlDataAdapter sda = new SqlDataAdapter(query, db.sqlCon);

            SqlCommandBuilder cmd = new SqlCommandBuilder(sda);

            DataTable dataTable = new DataTable();

            sda.Fill(dataTable);

            dataGridView1.DataSource = dataTable;

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Home home = new Home();
            home.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            addLoans addloans = new addLoans();
            addloans.Show();
        }

        private void loanGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            LoanDeletion loanDeletion = new LoanDeletion();
            loanDeletion.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
