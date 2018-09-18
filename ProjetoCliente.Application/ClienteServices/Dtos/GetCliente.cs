using Abp.Application.Services.Dto;
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
    public class GetCliente : EntityDto<long>
    {
        public string Name { get; set; }

        public string Status { get; set; }

        public long DocumentoId { get; set; }
        public Documento Documento { get; set; }

        public List<Telefone> Telefones { get; set; }
    }
}
