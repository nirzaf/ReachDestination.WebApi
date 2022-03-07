using System.Threading.Tasks;
using Application.Interfaces.Repositories;
using Domain.Entities;
using Infrastructure.Persistence.Contexts;
using Infrastructure.Persistence.Repository;

namespace Infrastructure.Persistence.Repositories
{
    public class RouteRepositoryAsync : GenericRepositoryAsync<BusRoute>, IRouteRepositoryAsync
    {
        private readonly ApplicationDbContext _context;

        public RouteRepositoryAsync(ApplicationDbContext dbContext) : base(dbContext)
        {
            _context = dbContext;
        }

        public async Task<BusRoute?> FindNextRoute(PlayerResponse response)
        {
            var busRoutes = await _context.BusRoutes.FindAsync(response.BusRouteNo);

            if (response.SelectedValue)
            {
                switch (busRoutes?.TrueValue <= 15)
                {
                    case true:
                    {
                        var city = await _context.BusStations.FindAsync(busRoutes.TrueValue);
                        var routes = new BusRoute
                        {
                            RouteNumber = 123,
                            CurrentCity = city?.CityName,
                            TrueValue = 0,
                            FalseValue = 0,
                            Question = ""
                        };

                        return routes;
                    }
                    default:
                        return await _context.BusRoutes.FindAsync(busRoutes?.TrueValue);
                }
            }
            else
            {
                if (busRoutes?.TrueValue <= 15)
                {
                    var city = await _context.BusStations.FindAsync(busRoutes.FalseValue);
                    var routes = new BusRoute
                    {
                        RouteNumber = 123,
                        CurrentCity = city?.CityName,
                        TrueValue = 0,
                        FalseValue = 0,
                        Question = ""
                    };

                    return routes;
                }

                return await _context.BusRoutes.FindAsync(busRoutes?.FalseValue);
            }
        }
    }
}