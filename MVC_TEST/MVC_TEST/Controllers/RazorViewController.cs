using Microsoft.AspNetCore.Mvc;

namespace MVC_TEST.Controllers
{
    public class RazorViewController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
