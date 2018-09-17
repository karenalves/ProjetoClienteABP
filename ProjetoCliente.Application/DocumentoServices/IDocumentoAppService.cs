using Abp.Application.Services;
using ProjetoCliente.DocumentoServices.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCliente.DocumentoServices
{
    public interface IDocumentoAppService : IApplicationService
    {
        Task<IdDocumento> CreateDocumento(CreateDocumentoInput input);

        Task<GetDocumento> UpdateDocumento(GetDocumento input);

        Task<GetDocumento> GetByIdDocumento(long id);

        Task DeleteDocumento(long id);
    }
}
