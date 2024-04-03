using Microsoft.AspNetCore.Mvc;

namespace BestStoreMVC.Controllers
{
    public class ASecondController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
