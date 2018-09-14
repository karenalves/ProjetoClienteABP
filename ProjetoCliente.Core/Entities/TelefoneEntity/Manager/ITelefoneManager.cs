using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCliente.Entities.TelefoneEntity.Manager
{
    public interface ITelefoneManager
    {
        Task<long> CreateTelefone(Telefone telefone);
        Task<Telefone> UpdateTelefone(Telefone telefone);
        Task DeleteTelefone(long id);
        Task<Telefone> GetByIdTelefone(long id);
        Task<List<Telefone>> GetTelefoneCliente(long idCliente);
    }
}
