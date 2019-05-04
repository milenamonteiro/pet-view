using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetView
{
    public class StringConexao
    {
        private static String _connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=dbPetView;Integrated Security=True";
        public static string connectionString
        {
            get { return _connectionString; }
            set { _connectionString = value; }
        }
    }
}
