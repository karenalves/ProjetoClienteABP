using Abp.Application.Services;

namespace ProjetoCliente
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class ProjetoClienteAppServiceBase : ApplicationService
    {
        protected ProjetoClienteAppServiceBase()
        {
            LocalizationSourceName = ProjetoClienteConsts.LocalizationSourceName;
        }
    }
}