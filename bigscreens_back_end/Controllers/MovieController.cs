using bigscreens_back_end.Models;
using bigscreens_back_end.Data;
using Microsoft.AspNetCore.Mvc;

namespace bigscreens_back_end.Controllers
{
    [Route("api/Movies")]
    [Controller]
    public class MovieController : ControllerBase
    {
        private readonly IRepository _repository;

        public MovieController(IRepository repository)
        {
            _repository = repository;
        }

        // get all movies in the database
        [HttpGet]
        public ActionResult<List<Movie>> GetAllMovies()
        {
            try
            {
                return Ok(_repository.GetAllMovies());
            }
            catch (Exception)
            {

                return StatusCode(500);
            }
        } 
        // get movie by id
        [HttpGet]
        [Route("{id}")]
        public ActionResult<Movie> GetMovieById(int id)
        {
            try
            {
                return Ok(_repository.GetMovieById(id));
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }
        //create movie
        [HttpPost]
        public IActionResult CreateMovie (Movie movie)
        {
            try
            {
                // cheak for if the sent in data is valid 
                if (ModelState.IsValid)
                {
                    _repository.CreateMovie(movie);
                    //return Created("..", show);
                     return CreatedAtAction(nameof(GetMovieById), new { id = movie.Id }, movie);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception)
            {

                return StatusCode(500);
            }
        }
        [HttpPut]
        [Route("{id}")]
        public IActionResult UpdateMovie(int id, Movie movie)
        {
            try
            {
                Movie updateMovie = _repository.UpdateMovie(id, movie);

                if (updateMovie == null)
                {
                    return NotFound();
                }
                else
                {
                    return CreatedAtAction(nameof(GetMovieById), new { id = updateMovie.Id }, updateMovie);
                }
            }
            catch (Exception)
            {

                return StatusCode(500);
            }

            
        }




    }
}
