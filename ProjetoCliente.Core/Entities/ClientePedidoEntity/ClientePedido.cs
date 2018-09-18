using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCliente.Entities.ClientePedidoEntity
{
    public class ClientePedido
    {
        public long ClienteId { get; set; }

        public long PedidoId { get; set; }

        public ClientePedido(long ClienteId, long PedidoId)
        {
            this.ClienteId = ClienteId;
            this.PedidoId  = PedidoId;
        }
    }
}
