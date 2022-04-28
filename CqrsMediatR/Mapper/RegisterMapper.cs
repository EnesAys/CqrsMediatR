using AutoMapper;
using CqrsMediatR.Entities;
using CqrsMediatR.MedHandlers.Commands.Requests;
using CqrsMediatR.MedHandlers.Commands.Responses;
using CqrsMediatR.MedHandlers.Queries.Responses;

namespace CqrsMediatR.Mapper
{
    public class RegisterMapper : Profile
    {
        public RegisterMapper()
        {
            CreateMap<Product, GetProductByIdQueryResponse>();
            CreateMap<Product, GetProductsQueryResponse>();
            CreateMap<Product, UpdateProductCommandResponse>();
            CreateMap<CreateProductCommandRequest, Product>();
            CreateMap<UpdateProductCommandRequest, Product>();
        }
    }
}
