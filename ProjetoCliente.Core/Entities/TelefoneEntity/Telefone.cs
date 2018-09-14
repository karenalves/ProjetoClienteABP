using Abp.Domain.Entities.Auditing;
using ProjetoCliente.Entities.ClienteEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCliente.Entities.TelefoneEntity
{
    public class Telefone : FullAuditedEntity<long>
    {
        public int NumeroTelefone { get; set; }

        public string TipoTelefone { get; set; }

        public int ClienteId { get; set; }

        public Cliente Cliente;

        public Telefone()
        {
            this.CreationTime = DateTime.Now;
        }

        public Telefone(int tel, string tipoTel, int idCliente)
        {
            this.CreationTime = DateTime.Now;
            this.NumeroTelefone = tel;
            this.TipoTelefone = tipoTel;
            this.ClienteId = idCliente;
        }

    }
}
