using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using ViewingsApp.Models.Database;

namespace ViewingsApp.Repos
{
    public interface IPropertiesRepo
    {
        IEnumerable<Property> GetAllProperties();
    }
    
    public class PropertiesRepo : IPropertiesRepo
    {
        private readonly DatabaseContext _context;

        public PropertiesRepo(DatabaseContext context)
        {
            _context = context;
        }

        public IEnumerable<Property> GetAllProperties()
        {
            return _context.Properties.Include(property => property.Bookings);
        }
    }
}