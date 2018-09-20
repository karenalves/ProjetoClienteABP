using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.AutoMapper;
using Abp.Runtime.Validation;
using AutoMapper;
using ProjetoCliente.ClienteServices.Dtos;
using ProjetoCliente.Entities.ClienteEntity;
using ProjetoCliente.Entities.ClienteEntity.Manager;
using ProjetoCliente.Entities.PedidoEntity;
using ProjetoCliente.Entities.PedidoEntity.Manager;
using ProjetoCliente.PedidoServices;

namespace ProjetoCliente.ClienteServices
{
    [DisableValidation]
    public class ClienteAppService : ApplicationService, IClienteAppService
    {
        public ClienteManager _clienteManager;

        public PedidoManager  servicePedido;
        public ClienteAppService(ClienteManager clienteManager, PedidoManager pedido)
        {
            this._clienteManager = clienteManager;
            this.servicePedido = pedido;
        }
        public async Task<IdCliente> CreateCliente(CreateClienteInput input)
        {
            var cliente = input.MapTo<Cliente>();

            var idClienteCriado = await _clienteManager.CreateCliente(cliente);

            return new IdCliente
            {
                Id = idClienteCriado
            };
        }

        public async Task DeleteCliente(long id)
        {
            await _clienteManager.DeleteCliente(id);
        }

        public async Task<GetAllClientesOutput> GetAllCliente()
        {
            return new GetAllClientesOutput {
                Clientes = Mapper.Map<List<GetCliente>>(await _clienteManager.GetAllCliente())
            };
        }

        public async Task<GetCliente> GetByIdCliente(long id)
        {
            return  Mapper.Map<GetCliente>(await _clienteManager.GetByIdCliente(id));
        }

        public async Task<GetCliente> UpdateCliente(GetCliente input)
        {
            var cliente = input.MapTo<Cliente>();
            return Mapper.Map<GetCliente>(await _clienteManager.UpdateCliente(cliente));
        }

        public async Task VincularPedido(long clienteId, long pedidoId)
        {
            var cliente = await _clienteManager.GetByIdCliente(clienteId);
            var pedido = await servicePedido.GetByIdPedido(pedidoId);

            await _clienteManager.VincularPedido(cliente, pedido);
        }

    }
}
