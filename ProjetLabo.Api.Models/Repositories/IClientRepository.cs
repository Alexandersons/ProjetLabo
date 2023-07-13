using ProjetLabo.Api.Models.Commands;
using ProjetLabo.Api.Models.Entities;
using ProjetLabo.Api.Models.Queries;
using Tools.Cqs.Commands;
using Tools.Cqs.Queries;

namespace ProjetLabo.Api.Models.Repositories
{
    public interface IClientRepository :
        ICommandHandler<AddClientCommand>,
        IQueryHandler<GetClientQuery, IEnumerable <Client>>,
        ICommandHandler<DeleteClientCommand>,
        ICommandHandler<UpdateClientCommand>
    {
    }
}


