using AwesomeNetworkM35.Models.Users;
using AwesomeNetworkM35.ViewModel.Account;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AwesomeNetworkM35.Controllers
{
    public class HomeController : Controller
    {
        private readonly SignInManager<User> _signInManager;

        public HomeController(SignInManager<User> signInManager)
        {
            _signInManager = signInManager;
        }

        [Route("")]
        [Route("[controller]/[action]")]
        public IActionResult Index()
        {
            if (_signInManager.IsSignedIn(User))
            {
                return RedirectToAction("MyPage", "AccountManager");
            }
            else
            {
                return View(new MainViewModel());
            }
        }

        [Route("[action]")]
        public IActionResult Privacy()
        {
            return View();
        }

    }
}
