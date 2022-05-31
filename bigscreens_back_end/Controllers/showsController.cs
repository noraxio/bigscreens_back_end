using bigscreens_back_end.Data;
using bigscreens_back_end.Models;
using Microsoft.AspNetCore.Mvc;

namespace bigscreens_back_end.Controllers
{
    [Route("api/bigscreens")]
    [Controller]
    public class showsController : ControllerBase
    {
        private readonly IRepository _repository;

        public showsController(IRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult<List<Show>> getAllShows()
        {
            try
            {
                return Ok( _repository.GetAllShows());
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult<Show> GetShowById(int id)
        {
            try
            {
                return Ok( _repository.GetShowById(id));
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpPost]
        public IActionResult CreateShow([FromBody]Show show)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _repository.CreateShow(show);
                     //return Created("..", show);
                     return CreatedAtAction(nameof(GetShowById), new { id = show.Id }, show);
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
        





    }
}
