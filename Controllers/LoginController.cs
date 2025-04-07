using Microsoft.AspNetCore.Mvc;

namespace Online_Medicine_Donation.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
