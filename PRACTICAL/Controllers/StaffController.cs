using Microsoft.AspNetCore.Mvc;

namespace PRACTICAL.Controllers
{
    public class StaffController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
