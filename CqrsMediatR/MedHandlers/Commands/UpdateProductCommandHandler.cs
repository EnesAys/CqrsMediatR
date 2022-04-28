using AutoMapper;
using CqrsMediatR.Entities;
using CqrsMediatR.MedHandlers.Commands.Requests;
using CqrsMediatR.MedHandlers.Commands.Responses;
using CqrsMediatR.Repositories;
using MediatR;

namespace CqrsMediatR.MedHandlers.Commands
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommandRequest, UpdateProductCommandResponse>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public UpdateProductCommandHandler(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public Task<UpdateProductCommandResponse> Handle(UpdateProductCommandRequest request, CancellationToken cancellationToken)
        {
            var mapProductRequest = _mapper.Map<Product>(request);
            var product = _productRepository.UpdateProduct(mapProductRequest);
            var mapProduct = _mapper.Map<UpdateProductCommandResponse>(product);
            return Task.FromResult(mapProduct);
        }
    }
}
