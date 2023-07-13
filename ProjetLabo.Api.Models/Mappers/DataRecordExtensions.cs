using ProjetLabo.Api.Models.Entities;
using System.Data;


namespace ProjetLabo.Api.Models.Mappers
{
    internal static class DataRecordExtensions
    {
        internal static Utilisateur ToUtilisateur(this IDataRecord dataRecord)
        {
            return new Utilisateur(
                (int)dataRecord["Id_Utilisateur"], 
                (string)dataRecord["Nom"], 
                (string)dataRecord["Prenom"], 
                (string)dataRecord["Email"]);
        }

        internal static Client ToClient(this IDataRecord dataRecord)
        {
            return new Client(
                (int)dataRecord["Id_Client"],
                (string)dataRecord["Nom_Societe"],
                (string)dataRecord["Num_Tva"],
                (string)dataRecord["Email"],
                (string)dataRecord["Adresse"],
                (string)dataRecord["Pays"],
                (string)dataRecord["Tel"]);
        }

    }
}
