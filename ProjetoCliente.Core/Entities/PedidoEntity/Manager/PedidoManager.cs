using Abp.Domain.Repositories;
using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCliente.Entities.PedidoEntity.Manager
{
    public class PedidoManager : IPedidoManager, IDomainService
    {
        private IRepository<Pedido, long> _pedidoRepository;

        public PedidoManager(IRepository<Pedido, long> pedidoRepository)
        {
            _pedidoRepository = pedidoRepository;
        }
        public async Task<long> CreatePedido(Pedido pedido)
        {
            return await _pedidoRepository.InsertAndGetIdAsync(pedido);
        }

        public async Task DeletePedido(long id)
        {
            await _pedidoRepository.DeleteAsync(id);
        }

        public async Task<List<Pedido>> GetAllPedido()
        {
            return await _pedidoRepository.GetAllListAsync();
        }

        public async Task<Pedido> GetByIdPedido(long id)
        {
            return await _pedidoRepository.GetAsync(id);
        }

        public async Task<Pedido> UpdatePedido(Pedido pedido)
        {
            return await _pedidoRepository.UpdateAsync(pedido);
        }
    }
}
