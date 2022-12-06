using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SMART.GCP.Purchasing.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "srinivas Reddy";
        }

    }
}
