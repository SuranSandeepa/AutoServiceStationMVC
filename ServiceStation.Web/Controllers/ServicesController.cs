using Microsoft.AspNetCore.Mvc;
using ServiceStation.Web.Models;

namespace ServiceStation.Web.Controllers
{
    public class ServicesController : Controller
    {
        [ViewData]
        public string PageTitle { get; set; }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details()
        {
            PageTitle = "Service Details";

            var service = new VehicleService
            {
                ID = 1,
                Title = "Oil Change",
                Description = "Change the oil in car",
                Cost = 13.12
            };

            return View(service);
        }
    }




}
