using CqrsMediatR.MedHandlers.Queries.QueryModels.Responses;
using MediatR;

namespace CqrsMediatR.MedHandlers.Queries.QueryModels.Requests
{
    public class GetProductsQueryRequest : IRequest<List<GetProductsQueryResponse>>
    {
    }
}
