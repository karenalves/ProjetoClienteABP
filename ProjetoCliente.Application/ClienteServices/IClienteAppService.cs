using Abp.Application.Services;
using ProjetoCliente.ClienteServices.Dtos;
using ProjetoCliente.Entities.ClienteEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCliente.ClienteServices
{
    public interface IClienteAppService : IApplicationService
    {
        Task<IdCliente> CreateCliente(CreateClienteInput input);

        Task<GetCliente> UpdateCliente(GetCliente input);

        Task<GetCliente> GetByIdCliente(long id);

        Task<GetAllClientesOutput> GetAllCliente();

        Task DeleteCliente(long id);

        Task VincularPedido(long clienteId, long pedidoId);



    }
}
