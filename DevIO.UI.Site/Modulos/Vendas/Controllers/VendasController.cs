using Microsoft.AspNetCore.Mvc;

namespace DevIO.UI.Site.Modulos.Vendas.Controllers
{
    [Area("Vendas")]
    public class VendasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
