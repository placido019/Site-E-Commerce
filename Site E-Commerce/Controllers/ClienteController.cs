using Microsoft.AspNetCore.Mvc;

namespace Site_E_Commerce.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
