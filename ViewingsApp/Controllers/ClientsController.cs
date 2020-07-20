using Microsoft.AspNetCore.Mvc;

namespace ViewingsApp.Controllers
{
    public class ClientsController : Controller
    {
        public IActionResult GetClients()
        {
            return View("ListClients");
        }   
    }
}