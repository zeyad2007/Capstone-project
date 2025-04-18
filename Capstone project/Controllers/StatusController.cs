using Microsoft.AspNetCore.Mvc;

namespace Capstone_project.Controllers
{
    public class StatusController : Controller
    {
        public IActionResult Status()
        {
            return View();
        }
    }
}
