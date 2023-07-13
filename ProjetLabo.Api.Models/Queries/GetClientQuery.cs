using ProjetLabo.Api.Models.Entities;
using Tools.Cqs.Queries;

namespace ProjetLabo.Api.Models.Queries
{
    public class GetClientQuery : IQueryDefinition<Client?>
    {
        public int Id_Client { get; init; }
        public int Id_Utilisateur { get; init; }
        public GetClientQuery(int id_client, int id_utilisateur)
        {
            Id_Client = id_client;
            Id_Utilisateur = id_utilisateur;
        }
    }
}