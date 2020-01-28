using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AngularClient.Controllers
{
    [Produces("application/json")] //specifies the expected type of responses
    [Route("api/[controller]/[action]")] //specifies the route to access the api methods
    [ApiController] //specifies that this object is used to serve HTTP API responses
    public class SampleDataController : ControllerBase //controller does NOT support views
    {
        //a response with an object and a default status code
        public ObjectResult ObjectActionResult()
        {
            return new ObjectResult(new { Name = "ObjectActionResult" });
        }

    }
}
