using Microsoft.AspNetCore.Mvc;

namespace Capstone_project.Controllers
{
        public class SelectController : Controller
        {
            public ActionResult Select(string name, string price, string day, string date)
            {
                ViewBag.Name = name ?? "Ahmed Samy";
                ViewBag.Price = price ?? "222";
                ViewBag.Day = day ?? "Monday";
                ViewBag.Date = date ?? "19 / 2 / 2025";

                return View("Select");
            }
        }
    }