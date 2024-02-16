using Microsoft.AspNetCore.Mvc;

namespace MvcCore.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
