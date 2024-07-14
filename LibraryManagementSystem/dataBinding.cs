using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    internal class dataBinding
    {
        public class Database
        {
            public SqlConnection sqlCon;
            string constr;

            public Database()
            {
                constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\University\Semester-6\Visual Programming\LibraryManagementSystem\LibraryManagementSystem\Database1.mdf"";Integrated Security=True";
                this.sqlCon = new SqlConnection(constr);
            }
        }
    }
}
