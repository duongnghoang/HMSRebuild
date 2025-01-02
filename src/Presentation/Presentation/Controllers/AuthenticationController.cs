using MediatR;
using Microsoft.AspNetCore.Mvc;
using Presentation.Contracts.Authentication;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AuthenticationController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public IActionResult Login(LoginRequest request)
        {
            return Ok("Hello World");
        }
    }
}