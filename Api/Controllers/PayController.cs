using Microsoft.AspNetCore.Mvc;
using Api.Services;
using Core.Entities;
using System.Threading.Tasks;
using Api.Dto;
using AutoMapper;
using System.Linq;
using Api.Helpers;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PayController : ControllerBase
    {
        private readonly PayService _payService;

        public PayController(PayService payService)
        {
            _payService = payService;
        }


        [HttpPost]
        [Route("Mobile")]
        public async Task<IActionResult> AddMobile([FromBody]MobileDto mobileDto)
        {
            if(ModelState.IsValid)
            {
                await _payService.AddMobile(mobileDto);
                return Ok("Success");
            }
           
            
            return BadRequest(ModelState.GetModelStateErrors());
        }

        
        [HttpPost]
        [Route("Charity")]
        public async Task<IActionResult> AddCharity([FromBody]CharityDto charityDto)
        {
            if(ModelState.IsValid)
            {
                await _payService.AddCharity(charityDto);
                return Ok();
            }
            
            return BadRequest();
        }

        [HttpPost]
        [Route("Communal")]
        public async Task<IActionResult> AddCommunal([FromBody]CommunalDto communalDto)
        {
            if(ModelState.IsValid)
            {
                await _payService.AddCommunal(communalDto);
                return Ok();
            }
            
            return BadRequest();
        }

        [HttpPost]
        [Route("Finance")]
        public async Task<IActionResult> AddFinance([FromBody]FinanceDto financeDto)
        {
            if(ModelState.IsValid)
            {
                await _payService.AddFinance(financeDto);
                return Ok();
            }
            
            return BadRequest();
        }
        
    }
}