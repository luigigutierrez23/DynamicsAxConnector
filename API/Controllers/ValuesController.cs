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
        Ber_Lg_ServicesConnectorTestClient clientAX = new Ber_Lg_ServicesConnectorTestClient();
        CallContext callContext = new CallContext();

        [HttpGet]
        public string getValue()
        {
            var text = clientAX.getTextAX(callContext);
            return text;
        }
    }
}