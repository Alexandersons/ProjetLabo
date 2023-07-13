using Tools.Cqs.Commands;

namespace ProjetLabo.Api.Models.Commands
{
    public class RegisterCommand : ICommandDefinition
    {
        public string Nom { get; init; }
        public string Prenom { get; init; }
        public string Email { get; init; }
        public string Password { get; init; }

        public RegisterCommand(string nom, string prenom, string email, string password)
        {
            Nom = nom;
            Prenom = prenom;
            Email = email;
            Password = password;
        }
    }
}