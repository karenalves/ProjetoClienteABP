using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace ProjetoCliente.EntityFramework.Repositories
{
    public abstract class ProjetoClienteRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<ProjetoClienteDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected ProjetoClienteRepositoryBase(IDbContextProvider<ProjetoClienteDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class ProjetoClienteRepositoryBase<TEntity> : ProjetoClienteRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected ProjetoClienteRepositoryBase(IDbContextProvider<ProjetoClienteDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
