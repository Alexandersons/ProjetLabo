using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.Cqs.Commands;

namespace ProjetLabo.Api.Models.Commands
{
    public class AddClientCommand : ICommandDefinition
    {
        public string Nom_Societe { get; init; }
        public string Num_Tva { get; init; }
        public string Email { get; init; }
        public string Adresse { get; init; }
        public string? Tel { get; init; }
        public string Pays { get; init; }
        public int Id_Utilisateur { get; init; }

        public AddClientCommand(string nomSociete, string numTva, string email, string adresse, string? tel, string pays, int id_utilisateur)
        {
            Nom_Societe = nomSociete;
            Num_Tva = numTva;
            Email = email;
            Adresse = adresse;
            Tel = tel;
            Pays = pays;
            Id_Utilisateur = id_utilisateur;
        }

    }
}

