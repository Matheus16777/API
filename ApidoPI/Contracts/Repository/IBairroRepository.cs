using ApidoPI.Entity;
using System.Threading.Tasks;

namespace ApidoPI.Contracts.Repository
{
    public interface IBairroRepository
    {
        Task<IEnumerable<BairroEntity>> Get();
    }
}
