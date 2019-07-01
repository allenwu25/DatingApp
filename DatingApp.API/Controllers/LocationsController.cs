using System.Threading.Tasks;
using DatingApp.API.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DatingApp.API.Controllers
{
    [AllowAnonymous]
    [Route("api/[controller]")]
    [ApiController]
    public class LocationsController: ControllerBase
    {
        private readonly ILocationRepository _repo;
        public LocationsController(ILocationRepository repo) {
            _repo = repo;
        }
        [HttpGet]
        public async Task<IActionResult> GetLocations() {
            var locations = await _repo.GetLocations();
            return Ok(locations);
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetLocation(int id) {
            var location = await _repo.GetLocation(id);
            return Ok(location);
        }
        
    }
}
