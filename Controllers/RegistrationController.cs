using Microsoft.AspNetCore.Mvc;

namespace Online_Medicine_Donation.Controllers
{

    public class RegistrationController : Controller
    {
        public IActionResult NGORegister()
        {
            return View();
        }        
        public IActionResult UserRegister()
        {
            return View();
        }
    }
}
