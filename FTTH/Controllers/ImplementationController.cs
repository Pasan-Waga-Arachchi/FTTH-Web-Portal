using Microsoft.AspNetCore.Mvc;

namespace FTTH.Controllers
{
    public class ImplementationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
