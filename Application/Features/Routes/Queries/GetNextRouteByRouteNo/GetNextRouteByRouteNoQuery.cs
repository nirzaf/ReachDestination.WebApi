using System.Threading;
using System.Threading.Tasks;
using Application.Exceptions;
using Application.Interfaces.Repositories;
using Application.Wrappers;
using Domain.Entities;
using MediatR;

namespace Application.Features.Products.Queries.GetProductById
{
    public class GetNextRouteByRouteNoQuery : IRequest<Response<BusRoute>>
    {
        public PlayerResponse response { get; set; }

        public class
            GetNextRouteByRouteNoQueryHandler : IRequestHandler<GetNextRouteByRouteNoQuery, Response<BusRoute>>
        {
            private readonly IRouteRepositoryAsync _productRepository;

            public GetNextRouteByRouteNoQueryHandler(IRouteRepositoryAsync productRepository)
            {
                _productRepository = productRepository;
            }

            public async Task<Response<BusRoute>> Handle(GetNextRouteByRouteNoQuery query,
                CancellationToken cancellationToken)
            {
                var route = await _productRepository.FindNextRoute(query.response);
                if (route == null) throw new ApiException($"Route Not Found.");
                return new Response<BusRoute>(route);
            }
        }
    }
}