using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCliente.PedidoServices.Dtos
{
    public class GetPedido : EntityDto<long>
    {
        public string NomeProduto { get; set; }

        public int PrazoEntrega { get; set; }
    }
}
