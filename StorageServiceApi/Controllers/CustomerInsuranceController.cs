using Microsoft.AspNetCore.Mvc;
using StorageServiceApi.Requests;

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
            return BadRequest("Not implemented yet.");
        }
        
        [HttpPost]
        public async Task<IActionResult> CreateCustomerInsuranceAsync([FromHeader] CreateCustomerInsuranceRequest request)
        {
            return BadRequest("Not implemented yet.");
        }

    }
}