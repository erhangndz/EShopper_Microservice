using Microsoft.AspNetCore.Mvc;

namespace EShopper.SignalR.WebUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
