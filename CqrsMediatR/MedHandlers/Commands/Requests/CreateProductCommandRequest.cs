using MediatR;

namespace CqrsMediatR.MedHandlers.Commands.Requests
{
    public class CreateProductCommandRequest : IRequest<Guid>
    {
        public string Name { get; set; }
    }
}
