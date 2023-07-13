using ProjetLabo.Api.Models.Entities;
using Tools.Cqs.Queries;

namespace ProjetLabo.Api.Models.Queries
{
    public class GetClientQuery : IQueryDefinition<IEnumerable<Client>>
    {
        public int Id_Client { get; init; }

        public GetClientQuery(int id_client)
        {
            Id_Client = id_client;
        }
    }
}
