using Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Controllers
{
    
    
        [ApiController]
        [Route("api/[controller]")]
        public class ClientsController : ControllerBase
        {
            private readonly IClientService _clientService;

            public ClientsController(IClientService clientService)
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
