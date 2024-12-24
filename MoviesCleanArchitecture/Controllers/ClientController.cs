using Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MoviesCleanArchitecture.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IClientService _clientService;

        public ClientController(IClientService clientService)
        {
            _clientService = clientService;
        }

        [HttpGet("{clientId}/favorite-movies")]
        public IActionResult GetFavoriteMovies(int clientId)
        {
            var movies = _clientService.GetFavoriteMovies(clientId);
            if (!movies.Any())
            {
                return NotFound("No favorite movies found for this client.");
            }

            return Ok(movies);
        }

    }
}
