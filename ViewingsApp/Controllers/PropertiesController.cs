using Microsoft.AspNetCore.Mvc;
using ViewingsApp.Repos;

namespace ViewingsApp.Controllers
{
    [Route("properties")]
    public class PropertiesController : Controller
    {
        private readonly IPropertiesRepo _propertiesRepo;

        public PropertiesController(IPropertiesRepo propertiesRepo)
        {
            _propertiesRepo = propertiesRepo;
        }

        [HttpGet("")]
        public IActionResult GetProperties()
        {
            var properties = _propertiesRepo.GetAllProperties();
            return View("ListProperties", properties);
        }
    }
}