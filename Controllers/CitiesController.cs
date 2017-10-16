using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.Controllers
{
    public class CitiesController : Controller
    {
        public JsonResult GetCities()
        {
            return new JsonResult(new List<object>() {
                new { id=1, Name="Charrajevo" },
                new { id=2, Name="Garrido" }
            });
        }
    }
}
