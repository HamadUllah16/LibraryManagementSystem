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
    public partial class addMember : Form
    {
        public addMember()
        {
            InitializeComponent();
        }

        private void memberBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.memberBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet1);

        }

        private void addMember_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet1.Member' table. You can move, or remove it, as needed.
            

        }

        private void bookSubmit_Click(object sender, EventArgs e)
        {
            var userName = nameTextBox.Text.Trim();
            var userAddress = addressTextBox.Text.Trim();
            var userEmail = emailTextBox.Text.Trim();
            var userPhone = phoneTextBox.Text.Trim();


            SqlCommand sqlCmd;
            dataBinding.Database db;
            string query;

            query = "INSERT INTO Member(name,address,email,phone) VALUES('" +
                userName + "','" +
                userAddress + "', '" +
                userEmail + "','" +
                userPhone +
                "')";

            db = new dataBinding.Database();
            sqlCmd = new SqlCommand(query, db.sqlCon);

            SqlDataReader dataReader;

            try
            {
                db.sqlCon.Open();
                dataReader = sqlCmd.ExecuteReader();
                MessageBox.Show("Member Added Successfully");

                while (dataReader.Read())
                {

                }
                db.sqlCon.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error in Member insertion: " + err.Message);
            }
            this.Validate();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Members members = new Members();
            members.Show();
        }
    }
}
