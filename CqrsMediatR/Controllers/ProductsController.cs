using CqrsMediatR.MedHandlers.Commands.Requests;
using CqrsMediatR.MedHandlers.Queries.Requests;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CqrsMediatR.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        #region Queries

        [HttpGet]
        public async Task<IActionResult> GetAll() => Ok(await _mediator.Send(new GetProductsQueryRequest()));

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id) => Ok(await _mediator.Send(new GetProductByIdQueryRequest { Id = id }));

        #endregion

        #region Commands

        [HttpPost]
        public async Task<IActionResult> Post(CreateProductCommandRequest request) => Ok(await _mediator.Send(request));

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id) => Ok(await _mediator.Send(new DeleteProductCommandRequest { Id = id }));

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, UpdateProductCommandRequest request)
        {
            request.Id = id;
            return Ok(await _mediator.Send(request));
        }
        #endregion
    }
}
