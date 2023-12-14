using ApidoPI.Contracts.Repository;
using ApidoPI.DTO;
using ApidoPI.Entity;
using Microsoft.AspNetCore.Mvc;

namespace ApidoPI.Controllers
{
    [ApiController]
    [Route("connection_point")]
    public class CollectionPointController : ControllerBase
    {
     private readonly ICollectionPointRepository _ICollectionPointRepository;
     
     public CollectionPointController(ICollectionPointRepository ICollectionPointRepository)
        {
            _ICollectionPointRepository = ICollectionPointRepository;
        }
        [HttpGet]
        
        public async Task<IActionResult> Get()
        {
            return Ok(await _ICollectionPointRepository.Get());
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
          return Ok(await _ICollectionPointRepository.GetById(id));
        }
        [HttpPost]
        public async Task<IActionResult> Add(CollectionPointDTO collectionpoint)
        {
         await _ICollectionPointRepository.Add(collectionpoint);
         return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update(CollectionPointEntity collectionpoint)
        {
         await _ICollectionPointRepository.Update(collectionpoint);
         return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
         await _ICollectionPointRepository .Delete(id);
         return Ok();
        }
    }

}
