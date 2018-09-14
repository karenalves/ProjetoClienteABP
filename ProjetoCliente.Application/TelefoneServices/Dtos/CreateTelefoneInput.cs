using ProjetoCliente.Entities.ClienteEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCliente.TelefoneServices.Dtos
{
    public class CreateTelefoneInput
    {
        public int NumeroTelefone { get; set; }

        public string TipoTelefone { get; set; }

        public int ClienteId { get; set; }

        public Cliente Cliente;
    }
}
