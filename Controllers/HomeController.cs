using AwesomeNetworkM35.ViewModel.Account;
using Microsoft.AspNetCore.Mvc;

namespace AwesomeNetworkM35.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        [Route("[controller]/[action]")]
        public IActionResult Index()
        {
            return View(new MainViewModel());
        }

        [Route("[action]")]
        public IActionResult Privacy()
        {
            return View();
        }

    }
}
