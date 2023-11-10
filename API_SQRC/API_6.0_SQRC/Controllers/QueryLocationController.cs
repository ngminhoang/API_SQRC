using API_6._0_SQRC.Services.IServices;
using API_6._0_SQRC.Services.Services;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using Services_SQRC.MediatR.Query.IQuery;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_6._0_SQRC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QueryLocationController : ControllerBase
    {
        private readonly IMediator mediator;
        private readonly IQueryProvinceService qP;
        private readonly IQueryDistrictService qD;
        private readonly IQueryWardService qW;
        public QueryLocationController(IMediator mediator, IQueryProvinceService qP, IQueryDistrictService qD, IQueryWardService qW)
        {
            this.mediator = mediator;
            this.qP = qP;
            this.qD = qD;
            this.qW = qW;
        }
        // GET: api/<ValuesController>
        [HttpGet("Province")]
        public IActionResult getAllProvince()
        {
            try
            {
                return Ok(mediator.Send( new GetAllProvinceQuery()));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // GET api/<ValuesController>/5
        [HttpGet("Province/{id}")]
        public IActionResult getProvince(int id)
        {
            try
            {
                Log.Information("Request to DoSomething endpoint.");
                return Ok(qP.get(id));
            }
            catch (Exception ex)
            {
                Log.Error(ex, "An error occurred while processing the request.");
                throw ex;
            }
        }

        //// GET: api/<ValuesController>
        [HttpGet("District")]
        public IActionResult getAllDistrict()
        {
            try
            {
                return Ok(qD.getAll());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //// GET api/<ValuesController>/5
        [HttpGet("District/{id}")]
        public IActionResult getDistrict(int id)
        {
            try
            {
                return Ok(qD.get(id));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        //// GET: api/<ValuesController>
        [HttpGet("Ward")]
        public IActionResult getAllWard()
        {
            try
            {
                return Ok(qW.getAll());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //// GET api/<ValuesController>/5
        [HttpGet("Ward/{id}")]
        public IActionResult getWard(int id)
        {
            try
            {
                return Ok(qW.get(id));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
