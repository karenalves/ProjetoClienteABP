using Abp.Application.Services;
using ProjetoCliente.TelefoneServices.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCliente.TelefoneServices
{
    public interface ITelefoneAppService : IApplicationService
    {
        Task<IdTelefone> CreateTelefone(CreateTelefoneInput input);

        Task<GetTelefone> UpdateTelefone(GetTelefone input);

        Task<GetTelefone> GetByIdTelefone(long id);

        Task<GetAllTelefone> GetTelefoneCliente(long idCliente);

        Task DeleteTelefone(long id);
    }
}
