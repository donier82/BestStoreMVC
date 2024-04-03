using Microsoft.AspNetCore.Mvc;

namespace BestStoreMVC.Controllers
{
    public class AThirdController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
