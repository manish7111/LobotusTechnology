using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ManagerLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelLayer;

namespace LobotusTechnology.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogisticsController : ControllerBase
    {
        public readonly ILogisticsManager manager;
        public LogisticsController(ILogisticsManager manager)
        {
            this.manager = manager;
        }
        [HttpPost]
        public ActionResult GetRatePerParcel(DataRequest request)
        {
            try
            {
                var result = this.manager.GetParcelRate(request);
                if (result != 0)
                {
                    return this.Ok(new { Status = true, Message = "Parcel rate in between cities is calculated", Data = result });
                }
                return this.BadRequest(new { Status = false, Message = "Error while fetching details" });
            }
            catch (Exception e)
            {
                return this.NotFound(new { Status = false, Message = e.Message });
            }
        }
    }
}