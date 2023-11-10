using MediatR;
using Microsoft.AspNetCore.Mvc;
using Services_4.Models;
using Services_SQRC.MediatR.Command.ICommand;
using Services_SQRC.MediatR.Query.IQuery;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_6._0_SQRC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProvinceController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ProvinceController(IMediator mediator)
        {
            _mediator = mediator;
        }



        [HttpGet("Province")]
        public IActionResult getAllProvince()
        {
            try
            {
                return Ok(_mediator.Send(new GetAllProvinceQuery()));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        [HttpGet("Province/{id}")]
        public IActionResult getProvince(int id)
        {
            try
            {
                return Ok(_mediator.Send(new GetProvinceQuery(id)));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        [HttpPost("Province")]
        public IActionResult createProvince([FromBody] ProvinceModel entity)
        {
            try
            {

                return Ok(_mediator.Send(new CreateProvinceCommand(entity)));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        [HttpPut("Province/{id}")]
        public IActionResult updateProvince(int id, [FromBody] ProvinceModel entity)
        {
            try
            {
                return Ok(_mediator.Send(new UpdateProvinceCommand(id,entity)));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        [HttpDelete("Province/{id}")]
        public IActionResult deteleProvince(int id)
        {
            try
            {
                return Ok(_mediator.Send(new DeleteProvinceCommand(id)));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
