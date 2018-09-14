using Abp.Web.Mvc.Controllers;

namespace ProjetoCliente.Web.Controllers
{
    /// <summary>
    /// Derive all Controllers from this class.
    /// </summary>
    public abstract class ProjetoClienteControllerBase : AbpController
    {
        protected ProjetoClienteControllerBase()
        {
            LocalizationSourceName = ProjetoClienteConsts.LocalizationSourceName;
        }
    }
}