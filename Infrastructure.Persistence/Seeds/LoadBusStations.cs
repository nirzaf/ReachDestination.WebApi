using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Entities;
using Infrastructure.Persistence.Contexts;

namespace Infrastructure.Persistence.Seeds
{
    public static class LoadBusStation
    {
        public static async Task SeedAsync(ApplicationDbContext context)
        {
            var station = new BusStation()
            {
                StationId = 1,
                CityName = "Akurana"
            };
            var station1 = new BusStation()
            {
                StationId = 2,
                CityName = "Kandy"
            };

            var station2 = new BusStation()
            {
                StationId = 3,
                CityName = "Matale"
            };
            var station3 = new BusStation()
            {
                StationId = 4,
                CityName = "Kegalle"
            };
            var station4 = new BusStation()
            {
                StationId = 5,
                CityName = "Gampola"
            };
            var station5 = new BusStation()
            {
                StationId = 6,
                CityName = "Polonnaruwa"
            };
            var station6 = new BusStation()
            {
                StationId = 7,
                CityName = "Kurunegala"
            };
            var station7 = new BusStation()
            {
                StationId = 8,
                CityName = "Colombo"
            };
            var station8 = new BusStation()
            {
                StationId = 9,
                CityName = "Galle"
            };
            var station9 = new BusStation()
            {
                StationId = 10,
                CityName = "Nuwareliya"
            };
            var station10 = new BusStation()
            {
                StationId = 11,
                CityName = "Hatton"
            };
            var station11 = new BusStation()
            {
                StationId = 12,
                CityName = "Jaffna"
            };
            var station12 = new BusStation()
            {
                StationId = 13,
                CityName = "Trinco"
            };
            var station13 = new BusStation()
            {
                StationId = 14,
                CityName = "Puttalam"
            };
            var station14 = new BusStation()
            {
                StationId = 15,
                CityName = "Vavuniya"
            };


            var stationsList = new List<BusStation>
            {
                station,
                station1,
                station2,
                station3,
                station4,
                station5,
                station6,
                station7,
                station8,
                station9,
                station10,
                station11,
                station12,
                station13,
                station14
            };

            await context.BusStations.AddRangeAsync(stationsList);
            await context.SaveChangesAsync();
        }
    }
}