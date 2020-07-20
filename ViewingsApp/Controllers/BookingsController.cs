using Microsoft.AspNetCore.Mvc;

namespace ViewingsApp.Controllers
{
    public class BookingsController : Controller
    {
        public IActionResult GetBookingForm()
        {
            return View("BookingForm");
        }   
    }
}