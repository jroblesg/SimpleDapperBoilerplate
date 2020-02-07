using System.Threading.Tasks;
using demo.Data.Repositories;
using demo.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace demo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class PeopleController : ControllerBase
    {
        private readonly demo.Data.Repositories.IPeopleRepository _people;
        public PeopleController(demo.Data.Repositories.IPeopleRepository people)
        {
            _people = people;
        }

        [HttpGet("ById")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> ById([FromBody]PeopleByIdRequest Input)
        {
            var res = await _people.GetById(Input);
            if (res == null)
            {
                return BadRequest("No se encontro People");
            }

            return Ok(res);
        }
    }
}