using ProjetoCliente.PedidoServices.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCliente.PedidoServices
{
    public interface IPedidoServices
    {
        Task<IdPedido> CreatePedido(CreatePedidoInput input);

        Task<GetPedido> UpdatePedido(GetPedido input);

        Task<GetPedido> GetByIdPedido(long id);

        Task DeletePedido(long id);

        Task<GetAllPedidoOutput> GetAllPedido();
    }
}
