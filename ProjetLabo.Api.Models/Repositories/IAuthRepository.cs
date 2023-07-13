using ProjetLabo.Api.Models.Commands;
using ProjetLabo.Api.Models.Entities;
using ProjetLabo.Api.Models.Queries;
using Tools.Cqs.Commands;
using Tools.Cqs.Queries;

namespace F23L034_GestContact.Api.Models.Repositories
{
    public interface IAuthRepository :
        ICommandHandler<RegisterCommand>,
        IQueryHandler<LoginQuery, Utilisateur?>
    {
    }
}
