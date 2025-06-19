using Microsoft.AspNetCore.Mvc;

namespace SREM.AI.Web.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreatePost()
        {
            return View();
        }
    }
}
