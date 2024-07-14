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
    public partial class Books : Form
    {
        public Books()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            AddBook addBook = new AddBook();
            addBook.Show();
        }

        private void Books_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet1.Books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.database1DataSet1.Books);

            dataBinding.Database db = new dataBinding.Database();

            string query = "SELECT * FROM Books";

            SqlDataAdapter sda = new SqlDataAdapter(query, db.sqlCon);

            SqlCommandBuilder cmd = new SqlCommandBuilder(sda);

            DataTable dataTable = new DataTable();

            sda.Fill(dataTable);

            booksDataView.DataSource = dataTable;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Home home = new Home();
            home.Show();
        }

        private void booksDataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            DeleteBook deleteBook = new DeleteBook();
            deleteBook.Show();
        }
    }
}
