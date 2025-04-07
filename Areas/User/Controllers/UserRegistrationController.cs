using Microsoft.AspNetCore.Mvc;

namespace Online_Medicine_Donation.Areas.User.Controllers
{
    [Area("User")]
    public class UserRegistrationController : Controller
    {
        [Route("UserRegistration")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
