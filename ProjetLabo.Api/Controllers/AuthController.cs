using ProjetLabo.Api.Models.Commands;
using ProjetLabo.Api.Models.Entities;
using ProjetLabo.Api.Models.Forms;
using ProjetLabo.Api.Models.Queries;
using ProjetLabo.Api.Models.Repositories;
using Microsoft.AspNetCore.Mvc;
using Tools.Cqs.Commands;

namespace GestContact.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly ILogger _logger;
        private readonly IAuthRepository _authRepository;

        public AuthController(IAuthRepository authRepository, ILogger<AuthController> logger)
        {
            _logger = logger;
            _authRepository = authRepository;
        }

        [HttpPost("Register")]
        public IActionResult Register([FromBody] RegisterForm form)
        {
            _logger.LogInformation($"Nouvel enregistrement d'utilisateur : {form.Nom} {form.Prenom} ({form.Email})");
            ICommandResult result = _authRepository.Execute(new RegisterCommand(form.Nom, form.Prenom, form.Email, form.Password));

            if (result.IsFailure)
            {
                _logger.LogError(result.Message);
                return BadRequest();
            }

            return NoContent();
        }

        [HttpPost("Login")]
        public IActionResult Login([FromBody] LoginForm form)
        {
            _logger.LogInformation($"Nouvel demande d'authentification : {form.Email}");
            Utilisateur? utilisateur = _authRepository.Execute(new LoginQuery(form.Email, form.Password));

            if (utilisateur is null)
            {
                _logger.LogWarning("Utilisateur Not Found");
                return NotFound();
            }

            return Ok(utilisateur);
        }
    }
}

