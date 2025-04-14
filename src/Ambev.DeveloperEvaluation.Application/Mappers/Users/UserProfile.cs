using Ambev.DeveloperEvaluation.Application.Commands.Users;
using Ambev.DeveloperEvaluation.Application.DTOs.Users;
using Ambev.DeveloperEvaluation.Application.Results.Users;
using Ambev.DeveloperEvaluation.Domain.Entities;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.Application.Mappers.Users;

public class UserProfile : Profile
{
    public UserProfile()
    {
        CreateMap<UserAddressGeolocationDTO, UserAddressGeolocation>().ReverseMap();
        CreateMap<UserAddressDTO, UserAddress>().ReverseMap();
        CreateMap<UserNameDTO, UserName>().ReverseMap();

        CreateMap<UserPostRequestDTO, CreateUserCommand>().ReverseMap();

        CreateMap<CreateUserCommand, User>().ReverseMap();
        CreateMap<CreateUserResult, User>().ReverseMap();
        CreateMap<CreateUserResult, UserPostResponseDTO>().ReverseMap();

        CreateMap<GetUserCommand, User>().ReverseMap();
        CreateMap<GetUserResult, User>().ReverseMap();
        CreateMap<GetUserResult, UserGetResponseDTO>().ReverseMap();
    }
}
