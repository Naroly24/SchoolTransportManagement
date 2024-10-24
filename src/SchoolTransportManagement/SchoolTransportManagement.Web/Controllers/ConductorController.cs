using Microsoft.AspNetCore.Mvc;

namespace SchoolTransportManagement.Web.Controllers
{
    public class ConductorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
