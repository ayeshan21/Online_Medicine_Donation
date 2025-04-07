using Microsoft.AspNetCore.Mvc;

namespace Online_Medicine_Donation.Areas.NGO.Controllers
{
    [Area("NGO")]
    public class NGORegistrationController : Controller
    {
        [Route("NGORegistration")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
