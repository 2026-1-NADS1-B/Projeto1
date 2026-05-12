using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;

namespace WinFormsApp1
{
    public partial class JogosDB : Form
    {
        private string connectionString = "Data Source=your_database.db";

        public JogosDB()
        {
            InitializeComponent();
            CriarTabelaSeAusente();
            CarregarDados();
        }
        private void CriarTabelaSeAusente()
        {
            using var connection = new SqliteConnection(connectionString);
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText =
            @"
                CREATE TABLE IF NOT EXISTS Jogos (
                    Id_Jogo INTEGER PRIMARY KEY AUTOINCREMENT,
                    Jogo VARCHAR(20) NOT NULL,
                    Descricao VARCHAR(255) NOT NULL,
                    Tema VARCHAR(20) NOT NULL,
                    Faixa_Etaria VARCHAR(20) NOT NULL
                );
            ";
            command.ExecuteNonQueryAsync();
        }
        private void CarregarDados()
        {
            using var connection = new SqliteConnection(connectionString);
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM Jogos";

            using (var reader = command.ExecuteReader())
            {
                var dataTable = new DataTable();
                dataTable.Load(reader);
                JogosGridView.DataSource = dataTable;
            }
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtJogo.Text) ||
                string.IsNullOrWhiteSpace(TxtDesc.Text) ||
                string.IsNullOrWhiteSpace(TxtTema.Text) ||
                string.IsNullOrWhiteSpace(TxtFaixaEt.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }

            using var connection = new SqliteConnection(connectionString);
            connection.Open();

            using var command = connection.CreateCommand();
            command.CommandText =
                "INSERT INTO Jogos (Jogo, Descricao, Tema, Faixa_Etaria) " +
                "VALUES (@Jogo, @Descricao, @Tema, @Faixa_Etaria);";
            command.Parameters.AddWithValue("@Jogo", TxtJogo.Text);
            command.Parameters.AddWithValue("@Descricao", TxtDesc.Text);
            command.Parameters.AddWithValue("@Tema", TxtTema.Text);
            command.Parameters.AddWithValue("@Faixa_Etaria", TxtFaixaEt.Text);

            command.ExecuteNonQuery();
            using var idCommand = connection.CreateCommand();
            idCommand.CommandText = "SELECT last_insert_rowid();";
            var idObj = idCommand.ExecuteScalar();
            long newId = 0;
            if (idObj is long l) newId = l;
            else if (idObj != null) newId = Convert.ToInt64(idObj);

            MessageBox.Show($"O jogo {TxtJogo.Text} foi cadastrado no ID: {newId}");

            CarregarDados();
        }
    }
}