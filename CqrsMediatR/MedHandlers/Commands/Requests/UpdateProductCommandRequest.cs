using CqrsMediatR.MedHandlers.Commands.Responses;
using MediatR;

namespace CqrsMediatR.MedHandlers.Commands.Requests
{
    public class UpdateProductCommandRequest : IRequest<UpdateProductCommandResponse>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
