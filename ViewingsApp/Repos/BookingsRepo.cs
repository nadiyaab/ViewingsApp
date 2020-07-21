using System.Linq;
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

            _context.SaveChanges();
            return GetBooking(bookingEntity.Entity.Id);
        }

        private Booking GetBooking(int id)
        {
            return _context.Bookings
                .Include(booking => booking.Agent)
                .Include(booking => booking.Property)
                .Single(booking => booking.Id == id);
        }
    }
}