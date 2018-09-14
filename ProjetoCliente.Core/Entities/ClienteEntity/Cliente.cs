using Abp.Domain.Entities.Auditing;
using ProjetoCliente.Entities.DocumentoEntity;
using ProjetoCliente.Entities.PedidoEntity;
using ProjetoCliente.Entities.TelefoneEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCliente.Entities.ClienteEntity
{
    public class Cliente : FullAuditedEntity<long>
    {
        public string Name { get; set; }

        [DefaultValue("Ativo")]
        public string Status { get; set; }

        public int DocumentoId { get; set; }
        public Documento Documento { get; set; }

        public List<Telefone> Telefones { get; set; }

        public ICollection<Pedido> Pedidos { get; set; }

        public Cliente()
        {
            this.CreationTime = DateTime.Now;
        }

        public Cliente(string name, string status, Documento doc, List<Telefone> tel)
        {
            this.CreationTime = DateTime.Now;
            this.Name = name;
            this.Status = status;
            this.Documento = doc;
            this.Telefones = tel;
        }
    }
}
