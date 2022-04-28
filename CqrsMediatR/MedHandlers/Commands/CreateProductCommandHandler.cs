using AutoMapper;
using CqrsMediatR.Entities;
using CqrsMediatR.MedHandlers.Commands.Requests;
using CqrsMediatR.Repositories;
using MediatR;

namespace CqrsMediatR.MedHandlers.Commands
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommandRequest, Guid>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public CreateProductCommandHandler(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }
        public Task<Guid> Handle(CreateProductCommandRequest request, CancellationToken cancellationToken)
        {
            var mapProductRequest = _mapper.Map<Product>(request);
            var productId = _productRepository.AddProduct(mapProductRequest);
            return Task.FromResult(productId);
        }
    }
}
