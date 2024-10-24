using Microsoft.AspNetCore.Mvc;

namespace SchoolTransportManagement.Web.Controllers
{
    public class VehiculoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
