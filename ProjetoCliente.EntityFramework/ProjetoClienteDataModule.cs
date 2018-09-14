using System.Data.Entity;
using System.Reflection;
using Abp.EntityFramework;
using Abp.Modules;
using ProjetoCliente.EntityFramework;

namespace ProjetoCliente
{
    [DependsOn(typeof(AbpEntityFrameworkModule), typeof(ProjetoClienteCoreModule))]
    public class ProjetoClienteDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            Database.SetInitializer<ProjetoClienteDbContext>(null);
        }
    }
}
