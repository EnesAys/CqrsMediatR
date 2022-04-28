using MediatR;

namespace CqrsMediatR.MedHandlers.Commands.Requests
{
    public class DeleteProductCommandRequest : IRequest<bool>
    {
        public Guid Id { get; set; }
    }
}
