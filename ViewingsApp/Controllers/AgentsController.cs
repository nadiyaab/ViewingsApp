using Microsoft.AspNetCore.Mvc;

namespace ViewingsApp.Controllers
{
    public class AgentsController : Controller
    {
        public IActionResult GetAgents()
        {
            return View("ListAgents");
        }
    }
}