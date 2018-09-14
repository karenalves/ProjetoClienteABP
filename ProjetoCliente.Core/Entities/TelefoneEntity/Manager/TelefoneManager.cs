using Abp.Domain.Repositories;
using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCliente.Entities.TelefoneEntity.Manager
{
    public class TelefoneManager : ITelefoneManager, IDomainService
    {
        private IRepository<Telefone, long> _telefoneRepository;

        public TelefoneManager(IRepository<Telefone, long> telefoneRepository)
        {
            _telefoneRepository = telefoneRepository;
        }
        public async Task<long> CreateTelefone(Telefone telefone)
        {
            return await _telefoneRepository.InsertAndGetIdAsync(telefone);
        }

        public async Task DeleteTelefone(long id)
        {
             await _telefoneRepository.DeleteAsync(id);
        }

        public async Task<List<Telefone>> GetTelefoneCliente(long id)
        {
            return await _telefoneRepository.GetAllListAsync(x=> x.ClienteId == id);
        }

        public async Task<Telefone> GetByIdTelefone(long id)
        {
            return await _telefoneRepository.GetAsync(id);
        }

        public async Task<Telefone> UpdateTelefone(Telefone telefone)
        {
            return await _telefoneRepository.UpdateAsync(telefone);
        }
    }
}
