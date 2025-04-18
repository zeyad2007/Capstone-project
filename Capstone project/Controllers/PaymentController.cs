using Microsoft.AspNetCore.Mvc;

namespace Capstone_project.Controllers
{
    public class PaymentController : Controller
    {
        public IActionResult Payment()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Payment(string cardNumber, string expiry, string cvc, string country, string postalCode)
        {
            // TODO: Add payment processing logic here
            ViewBag.Message = "Payment processed!";
            return View();
        }
    }
}
