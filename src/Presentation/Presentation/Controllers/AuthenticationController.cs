using Application.Authentication.Login;
using Application.Authentication.Register;
using Domain.Shared.Permissions;
using Infrastructure.Services.Authorization;
using Mapster;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Presentation.Common.Validations;
using Presentation.Contracts.Authentication;

namespace Presentation.Controllers
{
    [Route("api/authentication/")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ICommonValidator _validator;

        public AuthenticationController(IMediator mediator, ICommonValidator validator)
        {
            _mediator = mediator;
            _validator = validator;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest request)
        {
            var validationResult = await _validator.ValidateAsync(request);
            if (!validationResult.IsValid)
            {
                return BadRequest(validationResult);
            }

            var loginRequest = request.Adapt<LoginStaffCommand>();
            var result = await _mediator.Send(loginRequest);

            return Ok(result);
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterStaffRequest request)
        {
            var validationResult = await _validator.ValidateAsync(request);
            if (!validationResult.IsValid)
            {
                return BadRequest(validationResult);
            }

            var registerRequest = request.Adapt<RegisterStaffCommand>();
            var result = await _mediator.Send(registerRequest);
            return Ok(result);
        }

        [HasPermission(PermissionConstant.AddServices, PermissionConstant.Checkin)]
        [HttpGet]
        public IActionResult Test()
        {
            return Ok();
        }
    }
}