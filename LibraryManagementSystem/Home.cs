using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            this.Hide();
            Books books = new Books();
            books.Show();
        }

        private void btnLoan_Click(object sender, EventArgs e)
        {
            this.Hide();
            Loans loans = new Loans();
            loans.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Members members = new Members();
            members.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }
    }
}
