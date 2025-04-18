using Microsoft.AspNetCore.Mvc;

namespace Capstone_project.Controllers
{
    public class AccountController : Controller
    {
        // GET: /Account/Login
        public IActionResult Login()
        {
            return View();
        }


        // GET: /Account/SignUp
        public IActionResult SignUp()
        {
            return View();
        }

        // POST: /Account/SignUp
        [HttpPost]
        public IActionResult SignUp(string firstName, string lastName, string id, string email, string password)
        {
            // هنا ممكن تضيف لوجيك التسجيل في قاعدة البيانات

            // بعد التسجيل الناجح، مثلاً يرجعه للصفحة الرئيسية
            return RedirectToAction("Login");
        }


    }
}
