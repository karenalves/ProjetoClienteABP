﻿using System.Threading.Tasks;
using Abp.Domain.Repositories;

namespace ProjetoCliente.Entities.ClienteEntity.Manager
{
    public interface IClienteRepository : IRepository<Cliente, long>
    {
        new Task<Cliente> UpdateAsync(Cliente cliente);
    }
}
