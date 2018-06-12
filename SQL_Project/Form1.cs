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
    public partial class Form1 : Form
    {
        string connectionString = "Data Source=DESKTOP-IQR808E;Initial Catalog=QuintaDeBatatas;Integrated Security=True";

        SqlConnection connect;

        public Form1()
        {
            InitializeComponent();

            SqlConnection connect = new SqlConnection(connectionString);
            connect.Open();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
