using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Entities;
using Infrastructure.Persistence.Contexts;

namespace Infrastructure.Persistence.Seeds
{
    public static class LoadBusRoute
    {
        public static async Task SeedAsync(ApplicationDbContext context)
        {
            var route1 = new BusRoute()
            {
                RouteNumber = 593,
                TrueValue = 101,
                FalseValue = 291,
                Question = "Would you like to get into the bus No 593?",
                CurrentCity = "Akurana"
            };

            var route2 = new BusRoute()
            {
                RouteNumber = 101,
                TrueValue = 208,
                FalseValue = 114,
                Question = "Would you like to get into the bus No 101?",
                CurrentCity = "Kandy"
            };

            var route3 = new BusRoute()
            {
                RouteNumber = 208,
                TrueValue = 8,
                FalseValue = 9,
                Question = "Would you like to get into the bus No 208?",
                CurrentCity = "Kegalle"
            };

            var route4 = new BusRoute()
            {
                RouteNumber = 114,
                TrueValue = 10,
                FalseValue = 11,
                Question = "Would you like to get into the bus No 114?",
                CurrentCity = "Gampola"
            };

            var route5 = new BusRoute()
            {
                RouteNumber = 291,
                TrueValue = 286,
                FalseValue = 156,
                Question = "Would you like to get into the bus No 291?",
                CurrentCity = "Matale"
            };

            var route6 = new BusRoute()
            {
                RouteNumber = 286,
                TrueValue = 12,
                FalseValue = 13,
                Question = "Would you like to get into the bus No 286?",
                CurrentCity = "Polonnaruwa"
            };

            var route7 = new BusRoute()
            {
                RouteNumber = 156,
                TrueValue = 14,
                FalseValue = 15,
                Question = "Would you like to get into the bus No 156?",
                CurrentCity = "Kurunegal"
            };


            var routeList = new List<BusRoute>
            {
                route1,
                route2,
                route3,
                route4,
                route5,
                route6,
                route7
            };

            await context.BusRoutes.AddRangeAsync(routeList);
            await context.SaveChangesAsync();
        }
    }
}