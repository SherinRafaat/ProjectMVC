using Microsoft.AspNetCore.Mvc;

namespace ProjectMVC.Controllers
{
    public class CompanyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
