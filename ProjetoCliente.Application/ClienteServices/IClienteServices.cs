using Abp.Application.Services;
using ProjetoCliente.ClienteServices.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCliente.ClienteServices
{
    public interface IClienteServices : IApplicationService
    {
        Task<IdCliente> CreateCliente(CreateClienteInput input);

        Task<GetCliente> UpdateCliente(GetCliente input);

        Task<GetCliente> GetByIdCliente(long id);

        Task<GetAllClientesOutput> GetAllCliente();

        Task DeleteCliente(long id);
    }
}
