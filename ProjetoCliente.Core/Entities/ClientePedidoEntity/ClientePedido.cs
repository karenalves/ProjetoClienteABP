using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCliente.Entities.ClientePedidoEntity
{
    public class ClientePedido
    {
        public int ClienteId { get; set; }

        public int PedidoId { get; set; }

        public ClientePedido(int ClienteId, int PedidoId)
        {
            this.ClienteId = ClienteId;
            this.PedidoId  = PedidoId;
        }
    }
}
