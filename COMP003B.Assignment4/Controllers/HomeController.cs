using COMP003B.Assignment4_.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;


namespace COMP003B.Assignment4_.Controllers
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Register()
        {
            return View();
        }
        //Post: Studets/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(RegistrationViewModel registration)
        {
            //TODO: add model state validation
            if (ModelState.IsValid)
            {
               
                //TODO: redirect to Index
                return RedirectToAction(nameof(ThankYou));
            }
            return View();
        }
        public IActionResult ThankYou()
        {
            return View();
        }
    }
}
