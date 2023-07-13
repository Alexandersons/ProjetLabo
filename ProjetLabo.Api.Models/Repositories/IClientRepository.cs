using ProjetLabo.Api.Models.Commands;
using ProjetLabo.Api.Models.Entities;
using ProjetLabo.Api.Models.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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


