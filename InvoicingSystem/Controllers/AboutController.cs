using Microsoft.AspNetCore.Mvc;

namespace InvoicingSystem.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
