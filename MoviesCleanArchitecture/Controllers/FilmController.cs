using Application.Dtos;
using Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MoviesCleanArchitecture.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmController : ControllerBase
    {
        private readonly IFilmService _filmService;

        public FilmController(IFilmService filmService)
        {
            _filmService = filmService;
        }

        [HttpGet("films-classifies")]
        public  IActionResult GetFilmsClassifiesParGenre()
        {
            var filmsParGenre =  _filmService.ClassifierFilmsParGenre();

            return Ok(filmsParGenre); // Renvoie le dictionnaire des films classifiés par genre
        }
        [HttpPost("{filmId}/avis")]
        public IActionResult AjouterAvis(int filmId, [FromBody] AjouterAvisDto dto)
        {
            try
            {
                _filmService.AjouterAvis(filmId, dto.ClientId, dto.Commentaire, dto.Note);
                return Ok("Avis ajouté avec succès");
            }
            catch (Exception ex) { 
            return BadRequest(ex.Message);
            }
        }

        [HttpGet("{filmId}/moyenne-notes")]
        public  IActionResult GetMoyenneNotes(int filmId) {
            try
            {
                var moyenne = _filmService.CalculerMoyenneNotes(filmId);
                return Ok(new {FilmId=filmId,MoyenneNotes=moyenne});
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        
        }
        
    }
}
