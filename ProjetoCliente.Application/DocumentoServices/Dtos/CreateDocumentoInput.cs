using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCliente.DocumentoServices.Dtos
{
    public class CreateDocumentoInput 
    {
        public string TipoDocumento { get; set; }

        public int NumeroDocumento { get; set; }
    }
}
