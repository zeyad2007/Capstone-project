using Microsoft.AspNetCore.Mvc;

namespace Capstone_project.Controllers
{
    public class PrescriptionFormController : Controller
    {
        public IActionResult PrescriptionForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SubmitPrescription(IFormFile SignatureImage, string Diagnosis, string Medication, string Dosage, string Tests, string Notes)
        {
            if (SignatureImage != null && SignatureImage.Length > 0)
            {
                var fileName = Path.GetFileName(SignatureImage.FileName);
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/uploads", fileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    SignatureImage.CopyTo(stream);
                }

                // Optionally save the file path or name to the database
            }

            // You can now use the rest of the fields: Diagnosis, Medication, etc.
            return RedirectToAction("Confirmation"); // Or any other action/page
        }

    }
}
