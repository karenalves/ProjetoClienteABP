using Abp.Domain.Repositories;
using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjetoCliente.Entities.ClienteEntity.Manager
{
    public class ClienteManager : IClienteManager, IDomainService
    {
        private IRepository<Cliente, long> _clienteRepository;
    
        public ClienteManager(IRepository<Cliente, long> clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }
        public async Task<long> CreateCliente(Cliente cliente)
        {
            return await _clienteRepository.InsertAndGetIdAsync(cliente);
        }

        public async Task DeleteCliente(long id)
        {
           await _clienteRepository.DeleteAsync(id);
        }

        public async Task<List<Cliente>> GetAllCliente()
        {            
            return await Task.Run(() => _clienteRepository.GetAllIncluding(x => x.Documento,y=> y.Telefones).ToList());
        }

        public async Task<Cliente> GetByIdCliente(long id)
        {
           return await Task.Run(() => _clienteRepository.GetAllIncluding(x => x.Documento, y => y.Telefones).Where(x => x.Id == id).FirstOrDefault());
        }

        public async Task<Cliente> UpdateCliente(Cliente cliente)
        {
            return await _clienteRepository.UpdateAsync(cliente);
        }
    }
}
