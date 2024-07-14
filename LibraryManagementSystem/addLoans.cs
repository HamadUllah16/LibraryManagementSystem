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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LibraryManagementSystem
{
    public partial class addLoans : Form
    {
        public addLoans()
        {
            InitializeComponent();
        }

        private void loanBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.loanBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet1);

        }

        private void addLoans_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet1.Loan' table. You can move, or remove it, as needed.
          

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
            Loans loans = new Loans();
            loans.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var bookId = bookIdTextBox.Text.Trim();
            var memberId = memberIdTextBox.Text.Trim();
            var loanDate = loanDateTextBox1.Text.Trim();
            var returnDate = returnDateTextBox.Text.Trim();
            SqlCommand sqlCmd;
            dataBinding.Database db;
            string query;

            query = "INSERT INTO Loan(bookId,memberId,loanDate,returnDate) VALUES('" +
                bookId + "','" +
                memberId + "', '" +
                loanDate + "','" +
                returnDate +
                "')";

            db = new dataBinding.Database();
            sqlCmd = new SqlCommand(query, db.sqlCon);

            SqlDataReader dataReader;

            try
            {
                db.sqlCon.Open();
                dataReader = sqlCmd.ExecuteReader();
                MessageBox.Show("Loan Added Successfully");

                while (dataReader.Read())
                {

                }
                db.sqlCon.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error in Loan insertion: " + err.Message);
            }
            this.Validate();
        
    }

        private void loadDateLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
