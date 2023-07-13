using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.Cqs.Commands;

namespace ProjetLabo.Api.Models.Commands
{
    public class UpdateClientCommand : ICommandDefinition
    {
        public string Nom_Societe { get; init; }
        public string Num_Tva { get; init; }
        public string Email { get; init; }
        public string Adresse { get; init; }
        public string? Tel { get; init; }
        public string Pays { get; init; }
        public UpdateClientCommand(string nomSociete, string numTva, string email, string? tel, string adresse, string pays)
        {
            Nom_Societe = nomSociete;
            Num_Tva = numTva;
            Email = email;
            Adresse = adresse;
            Tel = tel;
            Pays = pays;
        }
    }
}