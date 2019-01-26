using Microsoft.AspNetCore.Mvc;

namespace HelloMVC.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            return Content("Hello MinVoiCe");
        }
    }
}
