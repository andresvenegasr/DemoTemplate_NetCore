using System;
using Microsoft.AspNetCore.Mvc;

namespace DemoTemplate_NetCore.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemoController : ControllerBase
    {        
        public IActionResult Get(){
            return Ok("Demo");
        }
    }
}