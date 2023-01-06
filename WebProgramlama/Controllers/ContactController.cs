using Microsoft.AspNetCore.Mvc;

namespace WebProgramlama.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Contact()
        {
            return View("Contact");
        }
    }
}
