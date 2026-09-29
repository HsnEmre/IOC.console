using IOC.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace IOC.Web.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ISingletonDateService _singletonDateService;


        // private readonly IScopedDateService _scopedDateService;
        private readonly ITransientDateService _transienDateservice;
        //public HomeController(ISingletonDateService singletonDateService)
        //{
        //    _singletonDateService = singletonDateService;
        //}


        //public HomeController(IScopedDateService scopedDateService)
        //{
        //        _scopedDateService = scopedDateService; 
        //}

        public HomeController(ITransientDateService scopedDateService)
        {
            _transienDateservice = scopedDateService;
        }
        //public IActionResult Index([FromServices] ISingletonDateService singletonDateService2)
        //{

        //    ViewBag.time1= _singletonDateService.GetDateTime.TimeOfDay.ToString();

        //    ViewBag.time2=singletonDateService2.GetDateTime.TimeOfDay.ToString();
        //    return View();
        //}

        public IActionResult Index([FromServices] ITransientDateService scopeddateservice2)
        {

            ViewBag.time1 = _transienDateservice.GetDateTime.TimeOfDay.ToString();

            ViewBag.time2 = scopeddateservice2.GetDateTime.TimeOfDay.ToString();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
