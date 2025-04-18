using Microsoft.AspNetCore.Mvc;

namespace Capstone_project.Controllers
{
    public class DoctorController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
