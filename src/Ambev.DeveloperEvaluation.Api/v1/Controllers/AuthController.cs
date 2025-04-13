using Ambev.DeveloperEvaluation.Application.DTOs.Auth;
using Ambev.DeveloperEvaluation.Application.DTOs.Common;
using Ambev.DeveloperEvaluation.Application.Mappers.Auth;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Ambev.DeveloperEvaluation.Api.v1.Controllers;

[ApiController]
[Route("api/v{version:apiVersion}/[controller]")]
[ApiVersion("1.0")]
public class AuthController : ControllerBase
{
    private readonly IMediator _mediator;
    public AuthController(IMediator mediator)
    {
        _mediator = mediator;
    }

    /// <summary>
    /// Authenticates a user with their credentials.
    /// </summary>
    /// <param name="request">The authentication request.</param>
    /// <returns>Authentication token if successful.</returns>
    [HttpPost]
    [ProducesResponseType(typeof(AuthenticateUserResponseDTO), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ErrorResponseDTO), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorResponseDTO), StatusCodes.Status401Unauthorized)]
    public async Task<ActionResult<AuthenticateUserResponseDTO>> AuthenticateUser([FromBody] AuthenticateUserRequestDTO request)
    {
        var command = request.ToCommand();

        var result = await _mediator.Send(command);

        var response = result.ToResponseDTO();

        return Ok(response);
    }
}
