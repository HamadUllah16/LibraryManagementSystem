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
    public partial class DeleteMember : Form
    {
        public DeleteMember()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Members member = new Members();
            member.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var deleteMember = deleteMemberTextBox.Text.Trim();

            string query = "DELETE FROM Member WHERE ID='" + deleteMember + "'";
            dataBinding.Database db = new dataBinding.Database();

            try
            {
                db.sqlCon.Open();
                SqlCommand cmd = new SqlCommand(query, db.sqlCon);
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Member deleted.");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Exception in member deletion. "+ex.Message);
            }
        }
    }
}
