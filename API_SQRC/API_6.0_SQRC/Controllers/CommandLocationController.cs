using API_6._0_SQRC.Services.IServices;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Services_4.Models;
using Services_SQRC.MediatR.Command.ICommand;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_6._0_SQRC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommandLocationController : ControllerBase
    {
        private readonly IMediator mediator;
        private readonly ICommandProvinceService cP;
        private readonly ICommandDistrictService cD;
        private readonly ICommandWardService cW;
        public CommandLocationController(IMediator mediator, ICommandProvinceService cP, ICommandDistrictService cD, ICommandWardService cW) 
        {
            this.cP = cP;
            this.cD = cD;
            this.cW = cW;
            this.mediator = mediator;
        }
        

        // POST api/<ValuesController>
        [HttpPost("Province")]
        public IActionResult createProvince(ProvinceModel entity)
        {
            try
            {
                
                return Ok(mediator.Send( new CreateProvinceCommand(entity)));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // PUT api/<ValuesController>/5
        [HttpPut("Province/{id}")]
        public IActionResult updateProvince(int id,ProvinceModel entity)
        {
            try
            {
                return Ok(cP.update(id, entity));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("Province/{id}")]
        public IActionResult deteleProvince(int id)
        {
            try
            {
                return Ok(cP.delete(id));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        // POST api/<ValuesController>
        [HttpPost("District")]
        public IActionResult createDistrict(DistrictModel entity)
        {
            try
            {
                return Ok(cD.create(entity));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // PUT api/<ValuesController>/5
        [HttpPut("District/{id}")]
        public IActionResult updateDistrict(int id, DistrictModel entity)
        {
            try
            {
                return Ok(cD.update(id, entity));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("District/{id}")]
        public IActionResult deteleDistrict(int id)
        {
            try
            {
                return Ok(cD.delete(id));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // POST api/<ValuesController>
        [HttpPost("Ward")]
        public IActionResult createWard(WardModel entity)
        {
            try
            {
                return Ok(cW.create(entity));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // PUT api/<ValuesController>/5
        [HttpPut("Ward/{id}")]
        public IActionResult updateWard(int id, WardModel entity)
        {
            try
            {
                return Ok(cW.update(id, entity));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("Ward/{id}")]
        public IActionResult deteleWard(int id)
        {
            try
            {
                return Ok(cW.delete(id));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
