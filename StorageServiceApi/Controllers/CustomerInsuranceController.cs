using Microsoft.AspNetCore.Mvc;
using StorageServiceApi.Requests;
using StorageServiceApi.Responses;

namespace StorageServiceApi.Controller
{
    //Add a controller that handles all the CRUD methods. (Should be separeted into one controller for each entity.)
    [ApiController]
    [Route("api/customerinsurances")]
    public class CustomerInsuranceController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetCustomerInsuranceAsync([FromHeader] string customerNumber)
        {
            var response = new CustomerInsuranceResponse(){
                Id = 1,
                CustomerName = "Temp name",
                CustomerNumber = customerNumber,
                EmailAddress = "TempEmail",
                InsuranceName = "Temp Insurance Name",
                InsuredAmount = "1000000SEK"
            };
            return Ok(response);
           
        }

        [HttpPost]
        public async Task<IActionResult> CreateCustomerInsuranceAsync([FromHeader] CreateCustomerInsuranceRequest request)
        {
            var response = new CustomerInsuranceResponse(){
                Id = 1,
                CustomerName = "Temp name",
                CustomerNumber = "123456789000",
                EmailAddress = "TempEmail",
                InsuranceName = "Temp Insurance Name",
                InsuredAmount = "1000000SEK"
            };
            return Ok(response);
        }

    }
}