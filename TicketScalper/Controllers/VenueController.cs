using Microsoft.AspNetCore.Mvc;

namespace TicketScalper.Controllers
{
    public class VenueController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
