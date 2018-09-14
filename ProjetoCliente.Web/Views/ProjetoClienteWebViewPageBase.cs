using Abp.Web.Mvc.Views;

namespace ProjetoCliente.Web.Views
{
    public abstract class ProjetoClienteWebViewPageBase : ProjetoClienteWebViewPageBase<dynamic>
    {

    }

    public abstract class ProjetoClienteWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected ProjetoClienteWebViewPageBase()
        {
            LocalizationSourceName = ProjetoClienteConsts.LocalizationSourceName;
        }
    }
}