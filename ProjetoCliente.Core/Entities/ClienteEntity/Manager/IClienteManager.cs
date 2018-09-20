using ProjetoCliente.Entities.PedidoEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCliente.Entities.ClienteEntity.Manager
{
    public interface IClienteManager
    {
        Task<long> CreateCliente(Cliente cliente);
        Task<Cliente> UpdateCliente(Cliente cliente);
        Task DeleteCliente(long id);
        Task<Cliente> GetByIdCliente(long id);
        Task<List<Cliente>> GetAllCliente();

        Task VincularPedido(Cliente cliente, Pedido pedido);
    
    }
}
