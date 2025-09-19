using Microsoft.AspNetCore.Mvc;

namespace TicketScalper.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
