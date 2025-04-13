using Ambev.DeveloperEvaluation.Application.Commands.Auth;
using Ambev.DeveloperEvaluation.Application.DTOs.Auth;
using Ambev.DeveloperEvaluation.Application.Results.Auth;
using Ambev.DeveloperEvaluation.Domain.Entities;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.Application.Mappers.Auth;

public static class AuthenticateUserMappers
{
    private static readonly IMapper _mapper = new MapperConfiguration(cfg =>
        cfg.AddProfile<AuthenticateUserProfile>()).CreateMapper();

    public static AuthenticateUserCommand ToCommand(this AuthenticateUserRequestDTO dto)
    {
        return _mapper.Map<AuthenticateUserCommand>(dto);
    }

    public static AuthenticateUserResult ToResult(this User dto)
    {
        return _mapper.Map<AuthenticateUserResult>(dto);
    }

    public static AuthenticateUserResponseDTO ToResponseDTO(this AuthenticateUserResult result)
    {
        return _mapper.Map<AuthenticateUserResponseDTO>(result);
    }
}
