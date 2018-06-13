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

        public DataTable Count(SqlConnection connectionstring,string tabela)
        {
            DataTable result = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT COUNT(" + tabela + "ID) FROM " + tabela, connectionstring);
            adapter.Fill(result);

            return result;
        }
    }
}