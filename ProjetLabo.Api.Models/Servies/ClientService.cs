using ProjetLabo.Api.Models.Commands;
using ProjetLabo.Api.Models.Entities;
using ProjetLabo.Api.Models.Mappers;
using ProjetLabo.Api.Models.Queries;
using ProjetLabo.Api.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.Ado;
using Tools.Cqs.Commands;

namespace ProjetLabo.Api.Models.Services
{
    public class ClientService : IClientRepository
    {
        private readonly DbConnection _dbConnection;

        public ClientService(DbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public ICommandResult Execute(AddClientCommand command)
        {
            try
            {
                using (_dbConnection)
                {
                    _dbConnection.Open();
                    _dbConnection.ExecuteNonQuery("CSP_AddClient", true, command);
                    return ICommandResult.Success();
                }
            }
            catch (Exception ex)
            {
                return ICommandResult.Failure(ex.Message);
            }
        }

        public IEnumerable<Client> Execute(GetClientQuery query)
        {
            using (_dbConnection)
            {
                _dbConnection.Open();
                return _dbConnection.ExecuteReader("CSP_GetClient", (dr) => dr.ToClient(), true, query).ToList();
            }
        }

        public ICommandResult Execute(DeleteClientCommand command)
        {
            try
            {
                using (_dbConnection)
                {
                    _dbConnection.Open();
                    int rows = _dbConnection.ExecuteNonQuery("CSP_DeleteClient", true, command);

                    if (rows == 0)
                        return ICommandResult.Failure("Not Found");

                    return ICommandResult.Success();
                }
            }
            catch (Exception ex)
            {
                return ICommandResult.Failure(ex.Message);
            }
        }

        public ICommandResult Execute(UpdateClientCommand command)
        {
            try
            {
                using (_dbConnection)
                {
                    _dbConnection.Open();
                    int rows = _dbConnection.ExecuteNonQuery("CSP_UpdateClient", true, command);

                    if (rows == 0)
                        return ICommandResult.Failure("Not Found");

                    return ICommandResult.Success();
                }
            }
            catch (Exception ex)
            {
                return ICommandResult.Failure(ex.Message);
            }
        }
    }
}
