using Microsoft.AspNetCore.Mvc;

namespace Gwasanaeth.Web.Controllers
{
    public class AccountsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}