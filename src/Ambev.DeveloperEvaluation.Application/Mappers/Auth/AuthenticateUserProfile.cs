using Ambev.DeveloperEvaluation.Application.Commands.Auth;
using Ambev.DeveloperEvaluation.Application.DTOs.Auth;
using Ambev.DeveloperEvaluation.Application.Results.Auth;
using Ambev.DeveloperEvaluation.Domain.Entities;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.Application.Mappers.Auth;

public class AuthenticateUserProfile : Profile
{
    public AuthenticateUserProfile()
    {
        CreateMap<AuthenticateUserRequestDTO, AuthenticateUserCommand>().ReverseMap();

        CreateMap<User, AuthenticateUserResult>()
            .ForMember(dest => dest.Token, opt => opt.Ignore())
            .ForMember(dest => dest.Role, opt => opt.MapFrom(src => src.Role.ToString()));

        CreateMap<AuthenticateUserResult, AuthenticateUserResponseDTO>().ReverseMap();
    }
}
