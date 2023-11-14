using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Real_Estate_Property_Listing_Project.API.Controllers
{
    [Route("api/v2/[controller]")]
    [ApiController]
    public class ApiControllerBase : ControllerBase
    {
        private ISender mediator = null!;

        protected ISender Mediator => mediator
            ??= HttpContext.RequestServices
            .GetRequiredService<ISender>();
    }
}
