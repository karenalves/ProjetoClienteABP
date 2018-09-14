using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCliente.Entities.DocumentoEntity.Manager
{
    public interface IDocumentoManager
    {
        Task<long> CreateDocumento(Documento documento);
        Task<Documento> UpdateDocumento(Documento documento);
        Task DeleteDocumento(long id);
        Task<Documento> GetByIdDocumento(long id);
        Task<List<Documento>> GetAllDocumento();
    }
}
