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
    public partial class Members : Form
    {
        public Members()
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
            addMember addMember = new addMember();
            addMember.Show();

        }

        private void Members_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet1.Member' table. You can move, or remove it, as needed
            dataBinding.Database db = new dataBinding.Database();

            string query = "SELECT * FROM Member";

            SqlDataAdapter sda = new SqlDataAdapter(query, db.sqlCon);

            SqlCommandBuilder cmd = new SqlCommandBuilder(sda);

            DataTable dataTable = new DataTable();

            sda.Fill(dataTable);

            membersGridView.DataSource = dataTable;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Home home = new Home();
            home.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            DeleteMember deleteMember = new DeleteMember();
            deleteMember.Show();
        }
    }
}
