using Abp.Domain.Entities.Auditing;
using ProjetoCliente.Entities.ClienteEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCliente.Entities.PedidoEntity
{
    public class Pedido : FullAuditedEntity<long>
    {
        public string NomeProduto { get; set; }

        public int PrazoEntrega { get; set; }

        public ICollection<Cliente> Clientes { get; set; }

        public Pedido()
        {
            this.CreationTime = DateTime.Now;
        }

        public Pedido(string nomeProd, int prazoEnt)
        {
            this.CreationTime = DateTime.Now;
            this.NomeProduto = nomeProd;
            this.PrazoEntrega = prazoEnt;
        }
    }
}
