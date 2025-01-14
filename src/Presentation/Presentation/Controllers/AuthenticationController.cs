using FluentValidation;
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
        private readonly IValidator _validator;

        public AuthenticationController(IMediator mediator, IValidator validator)
        {
            _mediator = mediator;
            _validator = validator;
        }

        [HttpGet]
        public IActionResult Login(LoginRequest request)
        {
            return Ok("Hello World");
        }
    }
}