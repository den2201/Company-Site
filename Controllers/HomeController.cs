using Microsoft.AspNetCore.Mvc;

namespace My_company.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
