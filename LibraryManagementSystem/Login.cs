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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void authorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.authorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet1.Author' table. You can move, or remove it, as needed.
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            var user = "hamadullah16";
            var password = "hamadullah16";

            if(user == inputUsername.Text && password == inputPassword.Text)
            {
                this.Hide();
                Home home = new Home();
                home.Show();
                try
                {
                    dataBinding db = new dataBinding();
                }
                catch
                {
                    MessageBox.Show("DB Connection Failed");
                }
            }
            else
            {
                MessageBox.Show("Wrong credentials, try again.");
            }
        }
    }
}
