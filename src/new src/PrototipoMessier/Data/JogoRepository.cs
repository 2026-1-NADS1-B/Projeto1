using Microsoft.Data.Sqlite;
using PrototipoMessier.Models;
namespace PrototipoMessier.Data
{
    public class JogoRepository
    {
        private static string ConnectionString => DbHelper.ConnectionString;

        public static void CadastrarJogo(NovoJogo novoJogo)
        {
            using var connection = new SqliteConnection(ConnectionString);
    connection.Open();

                using var command = connection.CreateCommand();
                command.CommandText =
                    "INSERT INTO Jogos (Jogo, Descricao, Tema, Faixa_Etaria, Status) " +
                    "VALUES (@Jogo, @Descricao, @Tema, @Faixa_Etaria, @Status);";
                command.Parameters.AddWithValue("@Jogo", novoJogo.Jogo);
                command.Parameters.AddWithValue("@Descricao", novoJogo.Descricao);
                command.Parameters.AddWithValue("@Tema", novoJogo.Tema);
                command.Parameters.AddWithValue("@Faixa_Etaria", novoJogo.FaixaEtaria);
                command.Parameters.AddWithValue("@Status", novoJogo.Status);
                command.ExecuteNonQuery();
        }
    }
}
