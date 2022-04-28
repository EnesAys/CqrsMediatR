using CqrsMediatR.MedHandlers.Queries.Responses;
using MediatR;

namespace CqrsMediatR.MedHandlers.Queries.Requests
{
    public class GetProductsQueryRequest : IRequest<List<GetProductsQueryResponse>>
    {
    }
}
