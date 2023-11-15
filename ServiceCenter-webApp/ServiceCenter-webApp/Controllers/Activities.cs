using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ServiceCenter_webApp.Controllers
{
    public class ActivitiesController : Controller
    {
        [Authorize(AuthenticationSchemes = "Cookies")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
