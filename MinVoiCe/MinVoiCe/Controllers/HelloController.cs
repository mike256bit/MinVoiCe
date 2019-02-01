using Microsoft.AspNetCore.Mvc;

namespace MinVoiCe.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            return Content("Hello MinVoiCe");
        }
    }
}
