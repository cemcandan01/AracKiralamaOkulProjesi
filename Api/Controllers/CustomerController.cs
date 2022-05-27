using Sınıf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Api.Controllers
{
    public class CustomerController : ApiController
    {
        Customer customerAdd = new Customer();

        [HttpPost]
        public IHttpActionResult Add([FromBody] Customer customer)
        {
            var result = customerAdd.Add(customer);
            if (result)
            {
                return Ok(HttpStatusCode.OK);
            }
            return Ok(HttpStatusCode.BadRequest);
        }
    }
}
