using ProjetLabo.Api.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.Cqs.Queries;

namespace ProjetLabo.Api.Models.Queries
{
    public class LoginQuery : IQueryDefinition<Utilisateur?>
    {
        public string Email { get; init; }
        public string Password { get; init; }

        public LoginQuery(string email, string password)
        {
            Email = email;
            Password = password;
        }
    }
}
