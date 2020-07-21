using Microsoft.AspNetCore.Mvc;
using ViewingsApp.Repos;

namespace ViewingsApp.Controllers
{
    [Route("agents")]
    public class AgentsController : Controller
    {
        private readonly IAgentsRepo _agentsRepo;

        public AgentsController(IAgentsRepo agentsRepo)
        {
            _agentsRepo = agentsRepo;
        }

        [HttpGet("")]
        public IActionResult GetAgents()
        {
            var agents = _agentsRepo.GetAllAgents();
            return View("ListAgents", agents);
        }
    }
}