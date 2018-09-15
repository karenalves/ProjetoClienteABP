using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.AutoMapper;
using AutoMapper;
using ProjetoCliente.Entities.PedidoEntity;
using ProjetoCliente.Entities.PedidoEntity.Manager;
using ProjetoCliente.PedidoServices.Dtos;

namespace ProjetoCliente.PedidoServices
{
    public class PedidoServices : IPedidoServices
    {
        public PedidoManager _pedidoManager;
        public PedidoServices(PedidoManager pedidoManager)
        {
            this._pedidoManager = pedidoManager;
        }

        public async Task<IdPedido> CreatePedido(CreatePedidoInput input)
        {
            var pedido = input.MapTo<Pedido>();

            var idPedidoCriado = await _pedidoManager.CreatePedido(pedido);

            return new IdPedido
            {
                Id = idPedidoCriado
            };
        }

        public async Task DeletePedido(long id)
        {
            await _pedidoManager.DeletePedido(id);
        }

        public async Task<GetPedido> GetByIdPedido(long id)
        {
            return Mapper.Map<GetPedido>(await _pedidoManager.GetByIdPedido(id));
        }

        public async Task<GetPedido> UpdatePedido(GetPedido input)
        {
            var doc = input.MapTo<Pedido>();
            return Mapper.Map<GetPedido>(await _pedidoManager.UpdatePedido(doc));
        }
    }
}
