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
        DataTable result;
        SqlConnection c;

        string connectionString;

        public MainForm()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["SQL_Project.Properties.Settings.QuintaDeBatatasConnectionString"].ConnectionString;
        }

        private void Form1_Load(object sender, EventArgs e)
        { }

        private void listaColheitas_SelectedIndexChanged(object sender, EventArgs e)
        {
            Populate("Batata", listaColheitas);
        }

        private void Populate(string selection, ListBox lista)
        {
            c = new SqlConnection(connectionString);
            c.Open();
            result = new DataTable();
            result = util.selectAllFrom(c, selection);
            lista.DisplayMember = result.TableName + "ID";
            lista.ValueMember = lista.DisplayMember;
            lista.DataSource = result;
            c.Close();
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            if (TipoTextBox.Text.ToString() != null && DescTextBox.Text.ToString() != null &&
                EpocaTextBox.Text.ToString() != null)
            {
                string query = "Insert into Batata values(@Tipo, @Descricao, @Epoca, @PrecoKg)";

                SqlCommand command = new SqlCommand(query, c);

                c.Open();
                command.Parameters.AddWithValue("@Tipo", TipoTextBox.Text);
                command.Parameters.AddWithValue("@Descricao", DescTextBox.Text);
                command.Parameters.AddWithValue("@Epoca", EpocaTextBox.Text);
                command.Parameters.AddWithValue("@PrecoKg", PrecoTextBox.Text);

                command.ExecuteScalar();
                c.Close();
            }
            else
            {
                MessageBox.Show("Missing values!", "Failed Operation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}