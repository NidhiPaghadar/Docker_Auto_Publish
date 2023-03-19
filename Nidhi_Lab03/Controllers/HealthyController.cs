using Microsoft.AspNetCore.Mvc;

namespace COMP306_Nidhi_Lab3.Controllers
{
    [ApiController]
    [Route("healthy")]
    public class HealthyController : ControllerBase
    {

        [HttpGet(Name = "/")]
        public String Get()
        {
            return "Healthy";
        }
    }
}