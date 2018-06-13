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

        int i;

        string connectionString;

        public MainForm()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["SQL_Project.Properties.Settings.QuintaDeBatatasConnectionString"].ConnectionString;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Populate("Batata", listaBatatas);
            i = (int)util.Count(c, "Batata").Rows[0][0];
        }

        private void Populate(string selection, DataGridView lista)
        {
            c = new SqlConnection(connectionString);
            c.Open();
            result = new DataTable();
            result = util.selectAllFrom(c, selection);
            lista.DataSource = result;
            c.Close();
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            if (TipoTextBox.Text.ToString() != "" && DescTextBox.Text.ToString() != "" &&
                EpocaTextBox.Text.ToString() != "" && PrecoTextBox.Text.ToString() != "")
            {
                string query = "Insert into Batata values(@BatataID, @Tipo, @Descricao, @Epoca, @PrecoKg)";

                SqlCommand command = new SqlCommand(query, c);

                decimal preco = Convert.ToDecimal(PrecoTextBox.Text);

                c.Open();
                command.Parameters.AddWithValue("@BatataID", i++);
                command.Parameters.AddWithValue("@Tipo", TipoTextBox.Text);
                command.Parameters.AddWithValue("@Descricao", DescTextBox.Text);
                command.Parameters.AddWithValue("@Epoca", EpocaTextBox.Text);
                command.Parameters.AddWithValue("@PrecoKg", preco);

                command.ExecuteNonQuery();
                c.Close();
            }
            else
            {
                MessageBox.Show("Missing values!", "Failed Operation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Populate("Batata", listaBatatas);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in listaBatatas.SelectedRows)
            {
                string query = "DELETE FROM Batata WHERE BatataID = " + row.Cells[0].Value;

                SqlCommand command = new SqlCommand(query, c);

                c.Open();
                command.ExecuteNonQuery();
                c.Close();
            }

            i--;
            Populate("Batata", listaBatatas);
        }

        private void Change_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Batata SET Tipo = @Tipo, Descricao = @Descricao," +
                "Epoca = @Epoca, PrecoKg = @PrecoKg where BatataID = " + listaBatatas.SelectedRows[0].Cells[0].Value;

            SqlCommand command = new SqlCommand(query, c);

            decimal preco = Convert.ToDecimal(PrecoTextBox.Text);

            c.Open();
            command.Parameters.AddWithValue("@Tipo", TipoTextBox.Text);
            command.Parameters.AddWithValue("@Descricao", DescTextBox.Text);
            command.Parameters.AddWithValue("@Epoca", EpocaTextBox.Text);
            command.Parameters.AddWithValue("@PrecoKg", preco);

            command.ExecuteNonQuery();
            c.Close();

            Populate("Batata", listaBatatas);
        }

        private void listaBatatas_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                TipoTextBox.Text = listaBatatas.SelectedRows[0].Cells[1].Value.ToString();
                DescTextBox.Text = listaBatatas.SelectedRows[0].Cells[2].Value.ToString();
                EpocaTextBox.Text = listaBatatas.SelectedRows[0].Cells[3].Value.ToString();
                PrecoTextBox.Text = listaBatatas.SelectedRows[0].Cells[4].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Double Click the arrow on the left, not a random cell :(", "Error");
            }

        }
    }
}