using System.Collections.Generic;
using ViewingsApp.Models.Database;
using ViewingsApp.Models.Request;
using ViewingsApp.Models.ViewModel;

namespace ViewingsApp.Services
{
    public interface IBookingValidator
    {
        BookingValidation ValidateBooking(BookingRequest bookingRequest, IEnumerable<Agent> allAgents, IEnumerable<Property> allProperties);
    }
    
    public class BookingValidator : IBookingValidator
    {
        public BookingValidation ValidateBooking(BookingRequest bookingRequest, IEnumerable<Agent> allAgents, IEnumerable<Property> allProperties)
        {
            // check that the request has a name & phone number & email address.
            // check that the start time is in the future
            // check that the end time is after the start time
            // check that the end time is no more than an hour after the start time.
            // check that the request has a valid agent
            // check that the request has a valid property.
            // check that the agent doesn't have a booking that clashes.
            // check that the property doesn't have a booking that clashes.
            // respect the start and end times of the agent
            // check that the agent has enough time to get between the properties.
            // agent starts & ends each day from the office in kentish town (
            // don't allow small gaps between viewings

            return new BookingValidation
            {
                IsValid = true,
                ErrorMessage = null
            };
        }
    }
}