using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.AutoMapper;
using AutoMapper;
using ProjetoCliente.DocumentoServices.Dtos;
using ProjetoCliente.Entities.DocumentoEntity;
using ProjetoCliente.Entities.DocumentoEntity.Manager;

namespace ProjetoCliente.DocumentoServices
{
    public class DocumentoServices : IDocumentoServices
    {
        public DocumentoManager _documentoManager;
        public DocumentoServices(DocumentoManager documentoManager)
        {
            this._documentoManager = documentoManager;
        }

        public async Task<IdDocumento> CreateDocumento(CreateDocumentoInput input)
        {
            var doc = input.MapTo<Documento>();

            var idDocCriado = await _documentoManager.CreateDocumento(doc);

            return new IdDocumento
            {
                Id = idDocCriado
            };
        }

        public async Task DeleteDocumento(long id)
        {
            await _documentoManager.DeleteDocumento(id);
        }

        public async Task<GetDocumento> GetByIdDocumento(long id)
        {
            return Mapper.Map<GetDocumento>(await _documentoManager.GetByIdDocumento(id));
        }

        public async Task<GetDocumento> UpdateDocumento(GetDocumento input)
        {
            var doc = input.MapTo<Documento>();
            return Mapper.Map<GetDocumento>(await _documentoManager.UpdateDocumento(doc));
        }
    }
}
