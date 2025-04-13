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

        CreateMap<ProductPostRequestDTO, Product>().ReverseMap();

        CreateMap<ProductPutRequestDTO, Product>().ReverseMap();

        CreateMap<ProductRatingDTO, ProductRating>().ReverseMap();
    }
}
