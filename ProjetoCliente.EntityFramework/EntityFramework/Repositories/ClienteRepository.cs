using Abp.EntityFramework;
using ProjetoCliente.Entities.ClienteEntity;
using ProjetoCliente.Entities.ClienteEntity.Manager;
using ProjetoCliente.Entities.PedidoEntity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCliente.EntityFramework.Repositories
{
    public class ClienteRepository : ProjetoClienteRepositoryBase<Cliente,long> , IClienteRepository
    {
        public ClienteRepository(IDbContextProvider<ProjetoClienteDbContext> dbContextProvider)
       : base(dbContextProvider)
        {


        }

        public new async Task<Cliente> UpdateAsync(Cliente cliente)
        {
            Context.Entry(cliente).State = EntityState.Modified;
            Context.Entry(cliente.Documento).State = EntityState.Modified;
            Context.Entry(cliente.Telefones.FirstOrDefault()).State = EntityState.Modified;
            Context.Entry(cliente.Telefones.LastOrDefault()).State = EntityState.Modified;            
            

            await Context.SaveChangesAsync();

            return cliente;
        }
        public async Task Add(Cliente cliente, Pedido pedido)
        {
            cliente.Pedidos.Add(pedido);
            await Context.SaveChangesAsync();            
        }
    }
}
