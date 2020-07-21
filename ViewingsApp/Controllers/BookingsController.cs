using Microsoft.AspNetCore.Mvc;
using ViewingsApp.Models.Request;
using ViewingsApp.Repos;
using ViewingsApp.Services;

namespace ViewingsApp.Controllers
{
    [Route("bookings")]
    public class BookingsController : Controller
    {
        private readonly IBookingValidator _bookingValidator;
        private readonly IBookingsRepo _bookingsRepo;
        private readonly IAgentsRepo _agentsRepo;
        private readonly IPropertiesRepo _propertiesRepo;

        public BookingsController(IBookingsRepo bookingsRepo, IBookingValidator bookingValidator, IAgentsRepo agentsRepo, IPropertiesRepo propertiesRepo)
        {
            _bookingsRepo = bookingsRepo;
            _bookingValidator = bookingValidator;
            _agentsRepo = agentsRepo;
            _propertiesRepo = propertiesRepo;
        }

        [HttpGet("{propertyId}")]
        public IActionResult GetBookingForm([FromRoute] int propertyId)
        {
            return View("BookingForm");
        }

        [HttpPost("{propertyId}")]
        public IActionResult SubmitBookingForm([FromRoute] int propertyId, [FromBody] BookingRequest bookingRequest)
        {
            var allAgents = _agentsRepo.GetAllAgents();
            var allProperties = _propertiesRepo.GetAllProperties();
            var bookingValidation = _bookingValidator.ValidateBooking(bookingRequest, allAgents, allProperties);
            if (!bookingValidation.IsValid)
            {
                ModelState.AddModelError("", bookingValidation.ErrorMessage);
                return View("BookingForm", bookingRequest);
            }
            
            var booking = _bookingsRepo.MakeBooking(bookingRequest);
            return View("SuccessPage", booking);
        }
    }
}