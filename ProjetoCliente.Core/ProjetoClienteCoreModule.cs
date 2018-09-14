using System.Reflection;
using Abp.Modules;

namespace ProjetoCliente
{
    public class ProjetoClienteCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
