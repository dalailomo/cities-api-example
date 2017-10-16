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
                    Description = "Garrido is not spain",
                    PointsOfInterest = new List<PointOfInterestDto> {
                        new PointOfInterestDto() {
                            Id = 1,
                            Name = "El parke",
                            Description = "El parke garrido esta muy chido"
                        },
                        new PointOfInterestDto() {
                            Id = 2,
                            Name = "El luymar",
                            Description = "Ay el luymar que bonico es"
                        }
                    }
                },
                new CityDto() {
                    Id = 2,
                    Name = "Santa Marta",
                    Description = "Cuna de canis",
                    PointsOfInterest = new List<PointOfInterestDto> {
                        new PointOfInterestDto() {
                            Id = 3,
                            Name = "La tienda del alcar",
                            Description = "El oldenadol"
                        }
                    }
                },
                new CityDto() {
                    Id = 3,
                    Name = "San Jose",
                    Description = "Ay el payo",
                    PointsOfInterest = new List<PointOfInterestDto> {
                        new PointOfInterestDto() {
                            Id = 4,
                            Name = "La casa el kolega",
                            Description = "La casa el kolega nene primo q pasa"
                        },
                        new PointOfInterestDto() {
                            Id = 5,
                            Name = "Pai a saber",
                            Description = "ya no se ni que escribir"
                        }
                    }
                }
            };
        }
    }
}
