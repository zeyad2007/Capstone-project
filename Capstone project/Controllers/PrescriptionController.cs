using Microsoft.AspNetCore.Mvc;

namespace Capstone_project.Controllers
{
    public class PrescriptionController : Controller
    {
        public IActionResult Prescription()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> GeneratePrescription(
            string FirstName,
            string LastName,
            string Age,
            string Gender,
            string Diagnosis,
            string Medication1,
            string Medication2,
            string Tests,
            string Notes,
            IFormFile mediaUpload)
        {
            // Pass text data to the view via ViewBag
            ViewBag.FirstName = FirstName;
            ViewBag.LastName = LastName;
            ViewBag.Age = Age;
            ViewBag.Gender = Gender;
            ViewBag.Diagnosis = Diagnosis;
            ViewBag.Medication1 = Medication1;
            ViewBag.Medication2 = Medication2;
            ViewBag.Tests = Tests;
            ViewBag.Notes = Notes;

            // Handle file upload
            if (mediaUpload != null && mediaUpload.Length > 0)
            {
                var uploads = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads");

                if (!Directory.Exists(uploads))
                    Directory.CreateDirectory(uploads);

                var filePath = Path.Combine(uploads, mediaUpload.FileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await mediaUpload.CopyToAsync(stream);
                }

                var imagePath = "/uploads/" + mediaUpload.FileName;
                ViewBag.UploadedImage = imagePath;
            }

            return View("Prescription");
        }
    }
}
