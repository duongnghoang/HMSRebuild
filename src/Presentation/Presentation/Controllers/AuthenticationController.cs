﻿using Application.Authentication.Commands;
using Mapster;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Presentation.Common.Validations;
using Presentation.Contracts.Authentication;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
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

        [HttpPost]
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
    }
}