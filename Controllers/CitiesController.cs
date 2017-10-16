﻿using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.Controllers
{
    public class CitiesController : Controller
    {
        [HttpGet("api/cities")]
        public JsonResult GetCities()
        {
            return new JsonResult(CitiesDataStore.Current.Cities);
        }
    }
}
