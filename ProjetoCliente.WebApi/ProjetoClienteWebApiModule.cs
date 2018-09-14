using System.Reflection;
using Abp.Application.Services;
using Abp.Configuration.Startup;
using Abp.Modules;
using Abp.WebApi;

namespace ProjetoCliente
{
    [DependsOn(typeof(AbpWebApiModule), typeof(ProjetoClienteApplicationModule))]
    public class ProjetoClienteWebApiModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            Configuration.Modules.AbpWebApi().DynamicApiControllerBuilder
                .ForAll<IApplicationService>(typeof(ProjetoClienteApplicationModule).Assembly, "app")
                .Build();
        }
    }
}
