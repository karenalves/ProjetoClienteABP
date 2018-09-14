using ProjetoCliente.Entities.DocumentoEntity;
using ProjetoCliente.Entities.TelefoneEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCliente.ClienteServices.Dtos
{
    public class CreateClienteInput
    {
        public string Name { get; set; }

        public string Status { get; set; }

        public int DocumentoId { get; set; }
        public Documento Documento { get; set; }

        public List<Telefone> Telefones { get; set; }
    }
}
