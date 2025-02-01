using Microsoft.AspNetCore.Mvc;

namespace eticaretim.Controllers
{
    public class MainController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
