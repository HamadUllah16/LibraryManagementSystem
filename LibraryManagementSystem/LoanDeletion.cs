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
    public partial class LoanDeletion : Form
    {
        public LoanDeletion()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Loans loans = new Loans();
            loans.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var loanId = deleteLoanTextBox.Text.Trim();

            string query = "DELETE FROM Loan WHERE ID='" + loanId + "'";
            dataBinding.Database db = new dataBinding.Database();
            try
            {
                db.sqlCon.Open();
                SqlCommand cmd = new SqlCommand(query, db.sqlCon);
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Loan Deleted.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error in Loan Deletion. "+ex.Message);
            }
        }
    }
}
