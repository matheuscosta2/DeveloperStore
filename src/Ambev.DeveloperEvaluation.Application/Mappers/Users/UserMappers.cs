using Ambev.DeveloperEvaluation.Application.Commands.Users;
using Ambev.DeveloperEvaluation.Application.DTOs.Users;
using Ambev.DeveloperEvaluation.Application.Results.Users;
using Ambev.DeveloperEvaluation.Domain.Entities;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.Application.Mappers.Users;

public static class UserMappers
{
    private static readonly IMapper _mapper = new MapperConfiguration(cfg =>
        cfg.AddProfile<UserProfile>()).CreateMapper();

    public static User ToEntity(this CreateUserCommand command)
        => _mapper.Map<User>(command);

    public static User ToEntity(this GetUserCommand command)
        => _mapper.Map<User>(command);

    public static GetUserResult ToGetResult(this User entity)
        => _mapper.Map<GetUserResult>(entity);

    public static UserGetResponseDTO ToGetResponse(this GetUserResult entity)
        => _mapper.Map<UserGetResponseDTO>(entity);

    public static UserPostResponseDTO ToPostResponse(this CreateUserResult entity)
        => _mapper.Map<UserPostResponseDTO>(entity);

    public static CreateUserResult ToCreateResult(this User entity)
        => _mapper.Map<CreateUserResult>(entity);

    public static CreateUserCommand ToCommand(this UserPostRequestDTO dto)
        => _mapper.Map<CreateUserCommand>(dto);
}
