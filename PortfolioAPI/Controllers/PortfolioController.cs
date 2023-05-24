using Microsoft.AspNetCore.Mvc;

namespace PortfolioAPI.Controllers
{
    public class PortfolioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
