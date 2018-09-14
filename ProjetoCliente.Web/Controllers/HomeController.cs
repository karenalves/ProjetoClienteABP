using System.Web.Mvc;

namespace ProjetoCliente.Web.Controllers
{
    public class HomeController : ProjetoClienteControllerBase
    {
        public ActionResult Index()
        { 
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}