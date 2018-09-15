using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCliente.Entities.ClientePedidoEntity.Manager
{
    public interface IClientePedidoManager
    {
        Task<ClientePedido> CreateClientePedido(ClientePedido chaves);

        Task DeleteClientePedido(ClientePedido chaves);
    }
}
