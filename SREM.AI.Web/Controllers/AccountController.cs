using Microsoft.AspNetCore.Mvc;

namespace SREM.AI.Web.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Login(string returnUrl = "")
        {
            return View();
        }

        public async Task<IActionResult> Register()
        {
            return View();
        }
    }
}
