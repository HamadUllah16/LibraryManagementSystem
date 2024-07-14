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
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
        }

        private void authorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.authorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet1);

        }

        private void authorBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.authorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet1);

        }

        private void AddBook_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet1.Books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.database1DataSet1.Books);
            // TODO: This line of code loads data into the 'database1DataSet1.Author' table. You can move, or remove it, as needed.
            this.authorTableAdapter.Fill(this.database1DataSet1.Author);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var bookName = bookNameTextBox.Text.Trim();
            var author = authorTextBox.Text.Trim();
            var genre = genreTextBox.Text.Trim();
            var publicationYear = publicationYearTextBox.Text.Trim();

            SqlCommand sqlCmd;
            dataBinding.Database db;
            string query;

            query = "INSERT INTO Books(bookName,author,genre,publicationYear) VALUES('"+
                bookName+"','"+
                author+"', '"+
                genre+"','"+
                publicationYear+
                "')";

            db = new dataBinding.Database();
            sqlCmd = new SqlCommand(query, db.sqlCon);

            SqlDataReader dataReader;

            try
            {
                db.sqlCon.Open();
                dataReader = sqlCmd.ExecuteReader();
                MessageBox.Show("Book Added Successfully");

                while (dataReader.Read())
                {

                }
                db.sqlCon.Close();
            }
            catch(Exception err)
            {
                MessageBox.Show("Error in Book insertion: " + err.Message);
            }
            this.Validate();
        }

        private void idLabel_Click(object sender, EventArgs e)
        {

        }

        private void idTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void bookNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void bookNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void authorLabel_Click(object sender, EventArgs e)
        {

        }

        private void authorTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void genreLabel_Click(object sender, EventArgs e)
        {

        }

        private void genreTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void publicationYearLabel_Click(object sender, EventArgs e)
        {

        }

        private void publicationYearTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Books books = new Books();
            books.Show();
        }
    }
}
