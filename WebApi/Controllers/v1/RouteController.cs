using System.Threading.Tasks;
using Application.Features.Products.Queries.GetProductById;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers.v1
{
    [ApiVersion("1.0")]
    public class RouteController : BaseApiController
    {
        [HttpPost]
        public async Task<IActionResult> GetNextRoute(PlayerResponse res)
        {
            return Ok(await Mediator.Send(new GetNextRouteByRouteNoQuery { response = res }));
        }
    }
}