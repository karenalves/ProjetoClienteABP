using System.Threading.Tasks;
using Abp.Domain.Repositories;
using ProjetoCliente.Entities.PedidoEntity;

namespace ProjetoCliente.Entities.ClienteEntity.Manager
{
    public interface IClienteRepository : IRepository<Cliente, long>
    {
        new Task<Cliente> UpdateAsync(Cliente cliente);

        Task Add(Cliente cliente, Pedido pedido);
    }
}
