using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetLabo.Api.Models.Entities
{
    public class Utilisateur
    {
        public int Id_Utilisateur { get; init; }
        public string Nom { get; init; }
        public string Prenom { get; init; }
        public string Email { get; init; }

        internal Utilisateur(int id_utilisateur, string nom, string prenom, string email)
        {
            Id_Utilisateur = id_utilisateur;
            Nom = nom;
            Prenom = prenom;
            Email = email;
        }
    }
}
