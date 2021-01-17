using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

using API.AxConnectorServices;

namespace API.Controllers
{
    public class ValuesController : ApiController
    {
        BerLgAxServicesClient clientAX = new BerLgAxServicesClient();
        CallContext callContext = new CallContext();

        [HttpGet]
        public string getValue()
        {
            var text = clientAX.testService(callContext);
            return text;
        }
    }
}