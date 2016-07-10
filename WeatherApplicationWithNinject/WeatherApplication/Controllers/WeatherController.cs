using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WeatherApplication.Services;
using Ninject;

namespace WeatherApplication.Controllers
{
    public class WeatherController : Controller
    {
        private IWeatherService service;
        // GET: Weather
        public WeatherController(IWeatherService _service)
        {
            service = _service;
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GetWeather(string city,int term)
        {
            var result = service.GetWeatherForecast(city);
            ViewBag.days = term;
            return View(result);
        }

    }
}