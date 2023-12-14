using ApidoPI.Contracts.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ApidoPI.Controllers
{
    [ApiController]
    [Route("bairro")]
    public class BairroController : ControllerBase
    {
        private readonly IBairroRepository _bairroRepository;

        public BairroController(IBairroRepository bairroRepository)
        {
            _bairroRepository = bairroRepository;
        }
        [HttpGet]

        public async Task<IActionResult> Get()
        {
            return Ok(await _bairroRepository.Get());
        }
    }
}
