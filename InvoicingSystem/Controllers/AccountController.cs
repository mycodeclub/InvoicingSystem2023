using Microsoft.AspNetCore.Mvc;

namespace InvoicingSystem.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
