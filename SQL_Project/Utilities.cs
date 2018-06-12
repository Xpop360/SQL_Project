using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace SQL_Project
{
    class Utilities
    {
        public DataTable selectAllFrom(SqlConnection connectionstring, string tabela)
        {
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM " + tabela, connectionstring);
            DataTable result = new DataTable();
            adapter.Fill(result);
            return result;
        }
    }
}