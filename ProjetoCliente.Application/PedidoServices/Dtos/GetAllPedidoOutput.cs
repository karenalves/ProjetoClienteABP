using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCliente.PedidoServices.Dtos
{
    public class GetAllPedidoOutput
    {
        public List<GetPedido> Pedidos { get; set; }
    }
}
