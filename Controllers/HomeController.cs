using ClaimsSubmission.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ClaimsSubmission.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult SubmitClaim()
        {
            return View();
        }

        public IActionResult VerifyClaims()
        {
            return View();
        }

        public IActionResult UploadDocuments()
        {
            return View();
        }

        public IActionResult TrackStatus()
        {
            return View();
        }





        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
