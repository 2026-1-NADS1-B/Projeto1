using Microsoft.Data.Sqlite;
namespace PrototipoMessier.Data
{
    public class DbHelper
    {
        // Centralizamos o nome do banco de dados AQUI.
        public static string ConnectionString = "Data Source=messierdatabase.db";

        public void CriarTabelasSeAusente()
        {
            using var connection = new SqliteConnection(ConnectionString);
            connection.Open();
            using var command = connection.CreateCommand();

            // Cria a tabela de Jogos
            command.CommandText = @"
                CREATE TABLE IF NOT EXISTS Jogos (
                    Id_Jogo INTEGER PRIMARY KEY AUTOINCREMENT,
                    Jogo VARCHAR(20) NOT NULL,
                    Descricao VARCHAR(255) NOT NULL,
                    Tema VARCHAR(20) NOT NULL,
                    Faixa_Etaria VARCHAR(20) NOT NULL,
                    Status INTEGER DEFAULT 1 
                );
            ";
            command.ExecuteNonQuery();

            // Cria a tabela de Pacotes
            command.CommandText = @"
                CREATE TABLE IF NOT EXISTS Pacote (
                    ID_Pacote INTEGER PRIMARY KEY,
                    nome VARCHAR(100) NOT NULL,
                    preco_mensal DECIMAL(8,2) NOT NULL,
                    limite_mensal INT,
                    Jogos TEXT(1024)
                );
            ";
            command.ExecuteNonQuery();
        }
    }
}