using MySqlConnector;

namespace Pagamentos.Infra.Conexao.Interfaces
{
    public interface IPagamentosConexao
    {
        Task<MySqlConnection> GetConnectionAsync();
    }
}
