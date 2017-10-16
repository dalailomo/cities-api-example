using System;
using System.Collections.Generic;
using CityInfo.Models;

namespace CityInfo
{
    public class CitiesDataStore
    {
        // this allows getting an immutable instance to work with
        public static CitiesDataStore Current { get; } = new CitiesDataStore();

        public List<CityDto> Cities { get; set; }

        public CitiesDataStore() 
        {
            Cities = new List<CityDto>() {
                new CityDto() {
                    Id = 1,
                    Name = "Garrido",
                    Description = "Garrido is not spain"
                },
                new CityDto() {
                    Id = 2,
                    Name = "Santa Marta",
                    Description = "Cuna de canis"
                },
                new CityDto() {
                    Id = 3,
                    Name = "San Jose",
                    Description = "Ay el payo"
                }
            };
        }
    }
}
