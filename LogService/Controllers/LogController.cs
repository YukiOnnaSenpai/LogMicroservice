using Microsoft.AspNetCore.Mvc;
using LogDAL.Repositories.Implementations.Data;
using LogDAL.URIS2018_G1_M1.Data;

namespace LogService.Controllers
{
    [Route("api/log")]
    [ApiController]
    public class LogController : ControllerBase
    {
        private ErrorLogImplementation eli = new ErrorLogImplementation();
        private readonly GatewayLogImplementation gli = new GatewayLogImplementation();
        private readonly InfoLogImplementation ili = new InfoLogImplementation();

        [HttpGet]
        public ActionResult<ErrorLog> GetErrorLog()
        {
            int id = 1;
            ErrorLog el = eli.GetById(id);
            return el;
        }

        [HttpPost("/error")]
        public ActionResult<ErrorLog> SaveErrorLog([FromBody] ErrorLog log) {
            ErrorLog el = new ErrorLog
            {
                ErrorEndpoint = log.ErrorEndpoint,
                ErrrType = log.ErrrType,
                Timestamp = log.Timestamp,
            };
            eli.Add(el);
            return Ok();
        }

        [HttpPost("/info")]
        public ActionResult<InfoLog> SaveInfoLog([FromBody] InfoLog info) {
            InfoLog il = new InfoLog
            {
                UserAdressValidatedOn = info.UserAdressValidatedOn,
                UserCreatedOn = info.UserCreatedOn,
                UserCreditCardValidatedOn = info.UserCreditCardValidatedOn,
                UserEmailValidatedOn = info.UserEmailValidatedOn,
            };
            ili.Add(il);
            return Ok();
        }

        [HttpPost("/gateway")]
        public ActionResult<GatewayLog> SaveGatewayLog([FromBody] GatewayLog log) {
            GatewayLog gateway = new GatewayLog
            {
                GatewayEndpoint = log.GatewayEndpoint,
                EndTimestamp = log.EndTimestamp,
                StartTimestamp = log.StartTimestamp,
                UserId = log.UserId
            };
            gli.Add(gateway);
            return Ok();
        }
    }
}
