using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoCliente.ClienteServices.Dtos;
using ProjetoCliente.Entities.ClienteEntity.Manager;

namespace ProjetoCliente.ClienteServices
{
    public class ClienteServices : IClienteServices
    {
        public ClienteManager _clienteManager;
        public ClienteServices(ClienteManager clienteManager)
        {
            this._clienteManager = clienteManager;
        }
        public Task<IdCliente> CreateCliente(CreateClienteInput input)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCliente(long id)
        {
            throw new NotImplementedException();
        }

        public Task<GetAllClientesOutput> GetAllCliente()
        {
            throw new NotImplementedException();
        }

        public Task<GetCliente> GetByIdCliente(long id)
        {
            throw new NotImplementedException();
        }

        public Task<GetCliente> UpdateCliente(GetCliente input)
        {
            throw new NotImplementedException();
        }
    }
}
