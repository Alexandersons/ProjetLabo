using ProjetLabo.Api.Models.Commands;
using ProjetLabo.Api.Models.Entities;
using ProjetLabo.Api.Models.Forms;
using ProjetLabo.Api.Models.Queries;
using ProjetLabo.Api.Models.Repositories;
using Microsoft.AspNetCore.Mvc;
using Tools.Cqs.Commands;


namespace ProjetLabo.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IClientRepository _clientRepository;
        private readonly ILogger _logger;

        public ClientController(IClientRepository clientRepository, ILogger<ClientController> logger)
        {
            _clientRepository = clientRepository;
            _logger = logger;
        }

 
        // GET api/<ClientController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {

            Client? client = (Client?)_clientRepository.Execute(new GetClientQuery(id, 1));

            if (client is null)
                return NotFound();

            return Ok(client);
        }

        // POST api/<ClientController>
        [HttpPost]
        public IActionResult Post([FromBody] AddClientForm form)
        {

            ICommandResult result = _clientRepository.Execute(new AddClientCommand(form.Nom_Societe, form.Num_Tva, form.Email, form.Adresse, form.Tel, form.Pays, 1));

            if (result.IsFailure)
            {
                _logger.LogError(result.Message);
                return BadRequest();
            }

            return NoContent();
        }

        // PUT api/<ClientController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UpdateClientForm form)
        {
            ICommandResult result = _clientRepository.Execute(new UpdateClientCommand (form.Nom_Societe, form.Num_Tva, form.Email, form.Adresse, form.Tel, form.Pays));

            if (result.IsFailure)
            {
                if (result.Message == "Not Found")
                    return NotFound();

                _logger.LogError(result.Message);
                return BadRequest();
            }

            return NoContent();
        }

        //DELETE api/<ClientController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            ICommandResult result = _clientRepository.Execute(new DeleteClientCommand(id, 1));

            if (result.IsFailure)
            {
                if (result.Message == "Not Found")
                    return NotFound();

                _logger.LogError(result.Message);
                return BadRequest();
            }

            return NoContent();
        }
    }
}
