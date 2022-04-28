using CqrsMediatR.MedHandlers.Queries.QueryModels.Responses;
using MediatR;

namespace CqrsMediatR.MedHandlers.Queries.QueryModels.Requests
{
    public class GetProductByIdQueryRequest : IRequest<GetProductByIdQueryResponse>
    {
        public Guid Id { get; set; }
    }
}
