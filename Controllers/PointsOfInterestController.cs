﻿using System;
using System.Linq;
using CityInfo.Models;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.Controllers
{
    [Route("api/cities")]
    public class PointsOfInterestController : Controller
    {
        [HttpGet("{cityId}/pointsofinterest")]
        public IActionResult GetPointsOfInterest(int cityId)
        {
            var city = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == cityId);

            if (null == city) {
                return NotFound();
            }

            return Ok(city.PointsOfInterest);
        }

        [HttpGet("{cityId}/pointsofinterest/{id}", Name = "GetPointOfInterest")]
        public IActionResult GetPointOfInterest(int cityId, int id)
        {
            var city = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == cityId);

            if (null == city) {
                return NotFound();
            }

            return Ok(city.PointsOfInterest.FirstOrDefault(p => p.Id == id));
        }

        [HttpPost("{cityId}/pointsofinterest")]
        public IActionResult CreatePointOfInterest(
            int cityId, 
            [FromBody] PointOfInterestForCreationDto pointOfInterest
        ) {
            if (null == pointOfInterest) {
                return BadRequest();
            }

            var city = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == cityId);

            if (null == city) {
                return NotFound();
            }

            // demo purposes, horrible monster below - to be improved
            var maxPointOfInterestId = CitiesDataStore.Current.Cities.SelectMany(
                c => c.PointsOfInterest
            ).Max(p => p.Id);

            var finalPointOfInterest = new PointOfInterestDto() {
                Id = ++maxPointOfInterestId,
                Name = pointOfInterest.Name,
                Description = pointOfInterest.Description
            };

            city.PointsOfInterest.Add(finalPointOfInterest);

            return CreatedAtRoute("GetPointOfInterest", new {
                cityId = cityId,
                id = finalPointOfInterest.Id
            }, finalPointOfInterest);
        }
    }
}
