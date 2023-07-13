using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.Cqs.Commands;

namespace ProjetLabo.Api.Models.Commands
{
    public class DeleteClientCommand : ICommandDefinition
    {
        public int Id_Client { get; init; }
        public int UtilisateurId { get; init; }
        public DeleteClientCommand(int idClient, int utilisateurId)
        {
            Id_Client = idClient;
            UtilisateurId = utilisateurId;
        }
    }
}