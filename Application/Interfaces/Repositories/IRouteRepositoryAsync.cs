using System.Threading.Tasks;
using Domain.Entities;

namespace Application.Interfaces.Repositories
{
    public interface IRouteRepositoryAsync : IGenericRepositoryAsync<BusRoute>
    {
        Task<BusRoute?> FindNextRoute(PlayerResponse response);
    }
}