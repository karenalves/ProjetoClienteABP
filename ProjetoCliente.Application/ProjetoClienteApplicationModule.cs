using System.Reflection;
using Abp.Modules;

namespace ProjetoCliente
{
    [DependsOn(typeof(ProjetoClienteCoreModule))]
    public class ProjetoClienteApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
