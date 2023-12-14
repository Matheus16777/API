using ApidoPI.DTO;
using ApidoPI.Entity;

namespace ApidoPI.Contracts.Repository
{
    public interface ICollectionPointRepository
    {
        Task Add(CollectionPointDTO user);
        Task Update(CollectionPointEntity user);
        Task Delete (int id);
        Task <CollectionPointEntity> GetById(int id);
        Task <IEnumerable<CollectionPointEntity>> Get();
    }

}
