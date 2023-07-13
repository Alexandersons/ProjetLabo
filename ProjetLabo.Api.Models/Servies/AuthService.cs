using ProjetLabo.Api.Models.Mappers;
using ProjetLabo.Api.Models.Commands;
using ProjetLabo.Api.Models.Entities;
using ProjetLabo.Api.Models.Queries;
using ProjetLabo.Api.Models.Repositories;
using System.Data.Common;
using Tools.Ado;
using Tools.Cqs.Commands;

namespace ProjetLabo.Api.Models.Services
{
    public class AuthService : IAuthRepository
    {
        private readonly DbConnection _dbConnection;

        public AuthService(DbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public ICommandResult Execute(RegisterCommand command)
        {
            try
            {
                using (_dbConnection)
                {
                    _dbConnection.Open();
                    _dbConnection.ExecuteNonQuery("CSP_Register", true, command);
                    return ICommandResult.Success();
                }
            }
            catch (Exception ex)
            {
                return ICommandResult.Failure(ex.Message);
            }
        }

        public Utilisateur? Execute(LoginQuery query)
        {
            using (_dbConnection)
            {
                _dbConnection.Open();
                return _dbConnection.ExecuteReader("CSP_Login", (dr) => dr.ToUtilisateur(), true, query).SingleOrDefault();
            }
        }
    }
}
