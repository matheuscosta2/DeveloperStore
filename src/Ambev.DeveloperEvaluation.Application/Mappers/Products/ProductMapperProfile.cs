using Ambev.DeveloperEvaluation.Application.DTOs.Products;
using Ambev.DeveloperEvaluation.Domain.Entities;
using AutoMapper;
using System.Diagnostics.CodeAnalysis;

namespace Ambev.DeveloperEvaluation.Application.Mappers.Products;

[ExcludeFromCodeCoverage]
public class ProductMapperProfile : Profile
{
    public ProductMapperProfile()
    {
        CreateMap<Product, ProductGetDetailResponseDTO>().ReverseMap();
        CreateMap<Product, ProductGetResponseDTO>().ReverseMap();
        CreateMap<Product, ProductPutResponseDTO>().ReverseMap();
        CreateMap<Product, ProductPostResponseDTO>().ReverseMap();
        CreateMap<ProductPostRequestDTO, Product>()
            .ForMember(dest => dest.Rating, opt => opt.MapFrom(src => new ProductRating { Rate = src.Rating, Count = src.RateCount }))
            .ReverseMap();
        CreateMap<ProductPutRequestDTO, Product>().ReverseMap();
        CreateMap<ProductRatingDTO, ProductRating>().ReverseMap();
    }
}