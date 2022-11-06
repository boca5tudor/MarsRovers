using MarsRovers.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarsRovers.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RoverController : ControllerBase
    {
        private readonly IDataRepository _repository;
        public RoverController(IDataRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Rover>> Get()
        {

            try
            {
                var result = _repository.GetInstructions();

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest("Failed to get instructions");
            }
        }
    }
}
