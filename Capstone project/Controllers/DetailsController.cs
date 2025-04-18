using Microsoft.AspNetCore.Mvc;

namespace Capstone_project.Controllers
{
    public class DetailsController : Controller
    {
        public IActionResult AddDetails()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddDetails(IFormFile media)
        {
            string firstName = Request.Form["FirstName"];
            string lastName = Request.Form["LastName"];
            string age = Request.Form["Age"];
            string gender = Request.Form["Gender"];
            string diagnosis = Request.Form["Diagnosis"];
            string medication1 = Request.Form["Medication1"];
            string medication2 = Request.Form["Medication2"];
            string tests = Request.Form["Tests"];
            string notes = Request.Form["Notes"];

            // Optionally: save uploaded media
            if (media != null && media.Length > 0)
            {
                var uploads = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads");
                if (!Directory.Exists(uploads)) Directory.CreateDirectory(uploads);

                var filePath = Path.Combine(uploads, media.FileName);
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    media.CopyTo(stream);
                }

                ViewBag.UploadedImage = "/uploads/" + media.FileName;
            }

            ViewBag.FirstName = firstName;
            ViewBag.LastName = lastName;
            ViewBag.Age = age;
            ViewBag.Gender = gender;
            ViewBag.Diagnosis = diagnosis;
            ViewBag.Medication1 = medication1;
            ViewBag.Medication2 = medication2;
            ViewBag.Tests = tests;
            ViewBag.Notes = notes;

            return View("Prescription");
        }

    }
}
