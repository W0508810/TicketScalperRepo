using Microsoft.AspNetCore.Mvc;

namespace TicketScalper.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
