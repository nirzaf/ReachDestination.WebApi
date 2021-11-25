using System.Threading.Tasks;
using Domain.Entities;
using Infrastructure.Persistence.Contexts;
using Infrastructure.Persistence.Seeds;
using Microsoft.EntityFrameworkCore;
using Xunit;

namespace BusRouteUnitTest
{
    public class BusRouteUnitTest
    {
        [Fact]
        public async Task Return_Correct_Current_Bus_Route_Number_And_Next_Bus_Route_NumberAsync()
        {
            //Arrange
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase("TestApplicationDb")
                .Options;

            await using var context = new ApplicationDbContext(options);
            await LoadBusRoute.SeedAsync(context);
            await LoadBusStation.SeedAsync(context);
            var response = new PlayerResponse
            {
                BusRouteNo = 593,
                SelectedValue = true
            };

            var result = new BusRoute
            {
                RouteNumber = 593,
                TrueValue = 101,
                FalseValue = 291,
                CurrentCity = "Akurana"
            };


            //Act
            var route = await context.BusRoutes.FindAsync(response.BusRouteNo);


            //Assert
            Assert.Equal(result.RouteNumber, route.RouteNumber);
            Assert.Equal(result.TrueValue, route.TrueValue);
            Assert.Equal(result.FalseValue, route.FalseValue);
            Assert.Equal(result.CurrentCity, route.CurrentCity);
        }
    }
}