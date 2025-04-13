using Ambev.DeveloperEvaluation.Application.DTOs.BranchProducts;
using Ambev.DeveloperEvaluation.Domain.Entities;
using AutoMapper;
using System.Diagnostics.CodeAnalysis;

namespace Ambev.DeveloperEvaluation.Application.Mappers.BranchProducts;

[ExcludeFromCodeCoverage]
public class BranchProductMapperProfile : Profile
{
    public BranchProductMapperProfile()
    {
        CreateMap<BranchProductGetDetailResponseDTO, BranchProduct>().ReverseMap();

        CreateMap<BranchProductGetResponseDTO, BranchProduct>().ReverseMap();

        CreateMap<BranchProductPostRequestDTO, BranchProduct>().ReverseMap();

        CreateMap<BranchProductPostResponseDTO, BranchProduct>().ReverseMap();

        CreateMap<BranchProductPutRequestDTO, BranchProduct>().ReverseMap();

        CreateMap<BranchProductPutResponseDTO, BranchProduct>().ReverseMap();
    }
}
}
