using Abp.Domain.Repositories;
using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCliente.Entities.DocumentoEntity.Manager
{
    public class DocumentoManager : IDocumentoManager, IDomainService
    {
        private IRepository<Documento, long> _documentoRepository;
        public DocumentoManager(IRepository<Documento, long> documentoRepository)
        {
            _documentoRepository = documentoRepository;
        }
        public async Task<long> CreateDocumento(Documento documento)
        {
            return await _documentoRepository.InsertAndGetIdAsync(documento);
        }

        public async Task DeleteDocumento(long id)
        {
          await _documentoRepository.DeleteAsync(id);
        }

        public async Task<List<Documento>> GetAllDocumento()
        {
            return await _documentoRepository.GetAllListAsync();
        }

        public async Task<Documento> GetByIdDocumento(long id)
        {
            return await _documentoRepository.GetAsync(id);
        }

        public async Task<Documento> UpdateDocumento(Documento documento)
        {
            return await _documentoRepository.UpdateAsync(documento);
        }
    }
}
