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
    public partial class MainForm : Form
    {
        Utilities util = new Utilities();

        string connectionString;

        public MainForm()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["SQL_Project.Properties.Settings.QuintaDeBatatasConnectionString"].ConnectionString;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Populate("Plantacao", listaColheitas);
        }

        private void listaColheitas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Populate(string selection,ListBox lista)
        {
            SqlConnection c = new SqlConnection(connectionString);
            c.Open();
            DataTable result = new DataTable();
            result = util.selectAllFrom(c, selection);
            lista.DisplayMember = result.TableName + "ID";
            lista.ValueMember = lista.DisplayMember;
            lista.DataSource = result;
            c.Close();
        }
    }
}
