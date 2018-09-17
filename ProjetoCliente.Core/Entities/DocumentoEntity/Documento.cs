using Abp.Domain.Entities.Auditing;
using System;

namespace ProjetoCliente.Entities.DocumentoEntity
{
    public class Documento : FullAuditedEntity<long>
    {
        public string TipoDocumento { get; set; }

        public int NumeroDocumento { get; set; }

        public Documento()
        {
            this.CreationTime = DateTime.Now;
        }

        public Documento(string tipoDoc, int numDoc)
        {
            this.CreationTime = DateTime.Now;
            this.TipoDocumento = tipoDoc;
            this.NumeroDocumento = numDoc;
        }
    }
}
