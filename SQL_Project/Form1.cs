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
        int myFertilizer = 15, myTerrain = 2;

        int totalbatatas;

        string connectionString;

        public MainForm()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["SQL_Project.Properties.Settings.QuintaDeBatatasConnectionString"].ConnectionString;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Populate("Batata", listaBatatas);
            totalbatatas = (int)util.Count(c, "Batata").Rows[0][0];
            //InsertFert();
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
                string query = "Execute InsertBatata @BatataID, @Tipo, @Descricao, @Epoca, @PrecoKg";

                SqlCommand command = new SqlCommand(query, c);

                decimal preco = Convert.ToDecimal(PrecoTextBox.Text);

                c.Open();
                command.Parameters.AddWithValue("@BatataID", GenID(listaBatatas));
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
                string query = "Execute DeleteBatata @BatataID";

                SqlCommand command = new SqlCommand(query, c);

                command.Parameters.AddWithValue("@BatataID", row.Cells[0].Value);

                c.Open();
                command.ExecuteNonQuery();
                c.Close();
            }
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

        private void MtsTabelasEx(DataGridView lista)
        {
            DataTable result = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT Batata.Tipo FROM Batata JOIN Plantacao ON Batata.BatataID = Plantacao.BatataID "
                + "JOIN Terreno on Terreno.TerrenoID = Plantacao.TerrenoID " +
                "JOIN Fertilizante on Fertilizante.FertilizanteID = Plantacao.FertilizanteID " +
                "WHERE Plantacao.FertilizanteID = " + myFertilizer + " AND Plantacao.TerrenoID = " + myTerrain, connectionString);
            c.Open();
            adapter.Fill(result);
            lista.DataSource = result;
            c.Close();
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            MtsTabelasEx(dataGridView2);
        }

        private int GenID(DataGridView lista)
        {
            int k = 0;
            while(!CheckID(lista,k))
            {
                k++;
            }
            return k;
        }

        private bool CheckID(DataGridView lista, int k)
        {
            foreach (DataGridViewRow row in lista.Rows)
            {
                if (k == (int)row.Cells[0].Value)
                {
                    return false;
                }
            }
            return true;
        }
    }
}