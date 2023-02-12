using Dto;
using Microsoft.AspNetCore.Mvc;
using Services.Contract;
using Services.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommandeController : ControllerBase
    {

        private readonly ICommandeService _commandeService;

        public CommandeController(
           ICommandeService commandeService
           )
        {
            _commandeService = commandeService;
        }

        // GET: api/<CommandeController>
        [HttpGet]
        public IActionResult Get()
        {

            return Ok(_commandeService.GetList());
        }

        // GET api/<CommandeController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CommandeController>
        [HttpPost]
        public IActionResult Post([FromBody] Commande obj)
        {
            try
            {
                return Ok(_commandeService.Create(obj));
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
                
            }
            
        }

        // PUT api/<CommandeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CommandeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
