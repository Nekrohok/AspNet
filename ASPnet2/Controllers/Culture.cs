using Microsoft.AspNetCore.Mvc;

namespace ASPnet2.Controllers
{
    public class Culture : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
