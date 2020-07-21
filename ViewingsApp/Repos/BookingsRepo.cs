using Microsoft.EntityFrameworkCore;
using ViewingsApp.Models.Database;
using ViewingsApp.Models.Request;

namespace ViewingsApp.Repos
{
    public interface IBookingsRepo
    {
        Booking MakeBooking(BookingRequest bookingRequest);
    }
    
    public class BookingsRepo : IBookingsRepo
    {
        private readonly DatabaseContext _context;

        public BookingsRepo(DatabaseContext context)
        {
            _context = context;
        }

        public Booking MakeBooking(BookingRequest bookingRequest)
        {
            var bookingEntity = _context.Bookings.Add(
                new Booking
                {
                    AgentId = bookingRequest.AgentId,
                    PropertyId = bookingRequest.PropertyId,
                    StartsAt = bookingRequest.StartsAt,
                    EndsAt = bookingRequest.EndsAt,
                    Name = bookingRequest.Name,
                    PhoneNumber = bookingRequest.PhoneNumber,
                    EmailAddress = bookingRequest.EmailAddress
                }
            );

            return bookingEntity.Entity;
        }
    }
}