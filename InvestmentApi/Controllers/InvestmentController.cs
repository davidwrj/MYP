using Microsoft.AspNetCore.Mvc;

namespace InvestmentApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvestmentController : ControllerBase
    {
        [HttpGet(Name = "GetInvestment")]
        public object Get(Guid investmentId)
        {
            return "Here is your Investment";
        }

        [HttpDelete(Name = "DeleteInvestment")]
        public bool Delete(Guid InvestmentId)
        {
            return true;
        }

        [HttpPost(Name = "AddInvestment")]
        public bool AddInvestment(object investment)
        {
            return true;
        }

        [HttpPatch(Name = "UpdateInvestment")]
        public bool UpdateInvestment(Guid ownerId)
        {
            return false;
        }
    }
}
