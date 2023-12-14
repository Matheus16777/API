using ApidoPI.Contracts.Repository;
using ApidoPI.Entity;
using ApidoPI.Infraestructure;
using Dapper;

namespace ApidoPI.Repository
{
    public class BairroRepository : Connection, IBairroRepository
    {
        public async Task<IEnumerable<BairroEntity>> Get()
        {
            string sql = "SELECT * FROM bairro";
            return await GetConnection().QueryAsync<BairroEntity>(sql);
        }
    }
}
