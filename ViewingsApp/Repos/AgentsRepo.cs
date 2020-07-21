using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using ViewingsApp.Models.Database;

namespace ViewingsApp.Repos
{
    public interface IAgentsRepo {
        IEnumerable<Agent> GetAllAgents();
    }
    
    public class AgentsRepo : IAgentsRepo
    {
        private readonly DatabaseContext _context;

        public AgentsRepo(DatabaseContext context)
        {
            _context = context;
        }

        public IEnumerable<Agent> GetAllAgents()
        {
            return _context.Agents
                .Include(agent => agent.Bookings);
        }
    }
}