using CqrsMediatR.MedHandlers.Queries.Responses;
using MediatR;

namespace CqrsMediatR.MedHandlers.Queries.Requests
{
    public class GetProductByIdQueryRequest : IRequest<GetProductByIdQueryResponse>
    {
        public Guid Id { get; set; }
    }
}
