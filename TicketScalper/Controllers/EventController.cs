using Microsoft.AspNetCore.Mvc;

namespace TicketScalper.Controllers
{
    public class EventController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }

}
