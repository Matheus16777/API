using ApidoPI.Contracts.Repository;
using ApidoPI.DTO;
using ApidoPI.Entity;
using ApidoPI.Infraestructure;
using Dapper;
using Microsoft.OpenApi.Models;

namespace ApidoPI.Repository
{
    public class CollectionPointRepository:Connection,ICollectionPointRepository
    {
        public async Task Add(CollectionPointDTO user)
        {
            string sql = @"
            INSERT INTO collection_point (Name, Address, Number, Residue, bairro_Id)
                         VALUE(@Name, @Address, @Number, @Residue, @bairro_Id)
          ";
           await Execute(sql, user);
        
        }

        public async Task Delete(int id) 
        {
            string sql = "DELETE FROM collection_point WHERE Id = @id";
            await Execute(sql, new {id});
        }

        public async Task<IEnumerable<CollectionPointEntity>> Get()
        {
            string sql = "SELECT * FROM collection_point";
            return await GetConnection().QueryAsync<CollectionPointEntity>(sql);
        }

        public async Task<CollectionPointEntity> GetById(int id)
        {
            string sql = "SELECT * FROM collection_point WHERE Id = @id";
            return await GetConnection().QueryFirstAsync<CollectionPointEntity>(sql, new { id });
        }

        public async Task Update(CollectionPointEntity collectionpoint)
        {
            string sql = @"
                     UPDATE collection_point
                     SET Name = @Name,
                         Address = @Address,
                         Number = @Number,
                         Residue = @Residue,
                         bairro_Id = @bairro_Id
                     WHERE Id = @Id
            ";
            await Execute(sql, collectionpoint);
        }
    }
}
