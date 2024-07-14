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
    public partial class DeleteBook : Form
    {
        public DeleteBook()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Books books = new Books();
            books.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var bookId = deleteBookTextBox.Text.Trim();

            dataBinding.Database db = new dataBinding.Database();

            string query = "DELETE FROM Books WHERE ID='" + bookId + "'";

            try
            {
                db.sqlCon.Open();
                SqlCommand cmd = new SqlCommand(query, db.sqlCon);
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Book deleted.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error in deletion: "+ex.Message);
            }
        }
    }
}
