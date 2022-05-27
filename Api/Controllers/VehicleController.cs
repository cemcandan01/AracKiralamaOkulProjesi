
using Sınıf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Api.Controllers
{
    public class VehicleController : ApiController
    {
		Vehicle vehicleAdd = new Vehicle();

		[HttpGet]
		public IHttpActionResult GetAllVehicle()
		{
			var list = vehicleAdd.GetAllVeichle();
			return Ok(list);
		}

		[HttpPost]
		public IHttpActionResult Add([FromBody] Vehicle vehicle)
		{
			var result = vehicleAdd.Add(vehicle);
			if (result)
			{
				return Ok(HttpStatusCode.OK);
			}
			return Ok(HttpStatusCode.BadRequest);
		}

		[HttpGet]
		public IHttpActionResult GetById(int id)
		{
			var result = vehicleAdd.GetById(id);
			return Ok(result);
		}
	}
}
