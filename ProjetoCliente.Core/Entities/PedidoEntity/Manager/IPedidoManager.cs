using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCliente.Entities.PedidoEntity.Manager
{
    public interface IPedidoManager
    {
        Task<long> CreatePedido(Pedido pedido);
        Task<Pedido> UpdatePedido(Pedido pedido);
        Task DeletePedido(long id);
        Task<Pedido> GetByIdPedido(long id);
        Task<List<Pedido>> GetAllPedido();
    }
}
