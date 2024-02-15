using Microsoft.AspNetCore.Mvc;
using Mission6_Underwood.Models;
using System.Diagnostics;

namespace Mission6_Underwood.Controllers
{
    public class HomeController : Controller
    {
        private FormContext _context;
        public HomeController(FormContext temp) // Constructor
        {
            _context = temp;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GettoKnowJoel()
        {
            return View();
        }

        [HttpGet]
        public IActionResult MovieForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MovieForm(Form response)
        {
            _context.Forms.Add(response);
            _context.SaveChanges();


            return View("Confirmation", response);
        }
    }
}
