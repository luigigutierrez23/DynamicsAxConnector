using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

using API.AxConnectorServices;

namespace API.Controllers
{
    public class ProductsController : ApiController
    {
        BerLgAxServicesClient clientAX = new BerLgAxServicesClient();
        CallContext callContext = new CallContext();

        [HttpGet]
        public string getProducts()
        {
            var x = clientAX.executeRequest(callContext);
            return x;
        }
    }
}