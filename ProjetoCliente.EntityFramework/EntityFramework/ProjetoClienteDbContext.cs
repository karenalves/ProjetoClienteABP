using System.Data.Common;
using System.Data.Entity;
using Abp.EntityFramework;
using ProjetoCliente.Entities.ClienteEntity;
using ProjetoCliente.Entities.DocumentoEntity;
using ProjetoCliente.Entities.PedidoEntity;
using ProjetoCliente.Entities.TelefoneEntity;

namespace ProjetoCliente.EntityFramework
{
    public class ProjetoClienteDbContext : AbpDbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>()
                    .HasMany(l => l.Pedidos)
                    .WithMany(a => a.Clientes)
                    .Map(x =>
                    {
                        x.MapLeftKey("ClienteId");
                        x.MapRightKey("PedidoId");
                        x.ToTable("ClientePedido");
                    });
            base.OnModelCreating(modelBuilder);
        }
        //TODO: Define an IDbSet for each Entity...
        public virtual IDbSet<Pedido> Pedidos { get; set; }

        public virtual IDbSet<Documento> Documentos { get; set; }

        public virtual IDbSet<Cliente> Clientes { get; set; }

        public virtual IDbSet<Telefone> Telefones { get; set; }
        public object Cliente { get; internal set; }




        //Example:
        //public virtual IDbSet<User> Users { get; set; }

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public ProjetoClienteDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in ProjetoClienteDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of ProjetoClienteDbContext since ABP automatically handles it.
         */
        public ProjetoClienteDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public ProjetoClienteDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public ProjetoClienteDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }
    }
}
