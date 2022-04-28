using AutoMapper;
using CqrsMediatR.MedHandlers.Queries.QueryModels.Requests;
using CqrsMediatR.MedHandlers.Queries.QueryModels.Responses;
using CqrsMediatR.Repositories;
using MediatR;

namespace CqrsMediatR.MedHandlers.Queries.QueryModels
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQueryRequest, GetProductByIdQueryResponse>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public GetProductByIdQueryHandler(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }
        public Task<GetProductByIdQueryResponse> Handle(GetProductByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var product = _productRepository.GetProductById(request.Id);
            var mapProduct = _mapper.Map<GetProductByIdQueryResponse>(product);
            return Task.FromResult(mapProduct);
        }
    }
}
