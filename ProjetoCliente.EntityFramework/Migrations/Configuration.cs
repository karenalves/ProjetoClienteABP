using System.Data.Entity.Migrations;

namespace ProjetoCliente.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<ProjetoCliente.EntityFramework.ProjetoClienteDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "ProjetoCliente";
        }

        protected override void Seed(ProjetoCliente.EntityFramework.ProjetoClienteDbContext context)
        {
            // This method will be called every time after migrating to the latest version.
            // You can add any seed data here...
        }
    }
}
