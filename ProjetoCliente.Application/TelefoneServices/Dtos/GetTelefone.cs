using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCliente.TelefoneServices.Dtos
{
    public class GetTelefone : EntityDto<long>
    {
        public int NumeroTelefone { get; set; }

        public string TipoTelefone { get; set; }
    }
}
