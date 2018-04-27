using CityInfo.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API
{
    public class CityDataStore
    {
        public static CityDataStore Current { get; } = new CityDataStore();
        public List<CityDto> Cities { get; set; }
        public CityDataStore()
        {
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id=1,
                    Name="New York City",
                    Description="The one with that big park."
                },
                new CityDto()
                {
                    Id=2,
                    Name="Tiruchendur",
                    Description="The one where I feel I belong"
                },
                new CityDto()
                {
                    Id=3,
                    Name="Paris",
                    Description="The one with that big tower"
                }
            };
        }
    }
}
