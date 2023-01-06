using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebProgramlama.Controllers
{
    [Authorize(Roles ="Admin")]
    public class AdminPageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
