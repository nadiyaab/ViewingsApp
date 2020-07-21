using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ViewingsApp.Models.Request;
using ViewingsApp.Repos;
using ViewingsApp.Services;

namespace ViewingsApp.Controllers
{
    [Route("properties")]
    public class PropertiesController : Controller
    {
        private readonly IBookingValidator _bookingValidator;
        private readonly IBookingsRepo _bookingsRepo;
        private readonly IAgentsRepo _agentsRepo;
        private readonly IPropertiesRepo _propertiesRepo;

        public PropertiesController(IPropertiesRepo propertiesRepo, IBookingValidator bookingValidator, IBookingsRepo bookingsRepo, IAgentsRepo agentsRepo)
        {
            _propertiesRepo = propertiesRepo;
            _bookingValidator = bookingValidator;
            _bookingsRepo = bookingsRepo;
            _agentsRepo = agentsRepo;
        }

        [HttpGet("")]
        public IActionResult GetProperties()
        {
            var properties = _propertiesRepo.GetAllProperties();
            return View("ListProperties", properties);
        }
        
        [HttpGet("{propertyId}/book-viewing")]
        public IActionResult GetBookingForm([FromRoute] int propertyId)
        {
            var agents = _agentsRepo.GetAllAgents();
            var bookingRequest = new BookingRequest
            {
                PropertyId = propertyId,
                AllAgents = agents.Select(agent => new SelectListItem{Text = agent.Name, Value = agent.Id.ToString()})
            };
            return View("BookingForm", bookingRequest);
        }

        [HttpPost("{propertyId}/book-viewing")]
        public IActionResult SubmitBookingForm([FromForm] BookingRequest bookingRequest)
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