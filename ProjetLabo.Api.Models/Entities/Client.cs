using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetLabo.Api.Models.Entities
{
    public class Client
    {
        public int Id_Client { get; init; }
        public string Nom_Societe { get; init; }
        public string Num_Tva { get; init; }
        public string Email { get; init; }
        public string Adresse { get; init; }
        public string? Tel { get; init; }
        public string Pays { get; init; }
        public Client(int id_client, string nomSociete, string numTva, string email, string adresse, string? tel, string pays)
        {
            Id_Client = id_client;
            Nom_Societe = nomSociete;
            Num_Tva = numTva;
            Email = email;
            Adresse = adresse;
            Tel = tel;
            Pays = pays;
        }
    }
}
