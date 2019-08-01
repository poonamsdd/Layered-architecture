using SDWard.Service.Services.HealthCare;
using SDWardWebApi.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ViewModels;

namespace SDWardWebApi.Controllers
{
    public class HealthCareController : ApiController
    {
        private readonly IHealthService _health;
        private readonly JSON _json;
        public HealthCareController(IHealthService health, JSON json)
        {
            _health = health;
            _json = json;
        }
        // GET api/values
        public IHttpActionResult Get()
        {
            //JSON Json = new JSON();
            return Ok(_json.json("Success", _health.GetList()));
        }
        // GET api/values/5
        public IHttpActionResult Get(int id)
        {
            if (id==0)
            {
                return BadRequest("Error Occured");
            }
            var obj = _health.GetById(id);
            if (obj==null)
            {
                return NotFound();
            }
            return Ok(_json.json("Success", _health.GetById(id)));
        }
        // POST api/values
        [HttpPost]
        public IHttpActionResult Post([FromBody]HealthNotesModel obj)
        {
            if (obj==null)
            {
                return BadRequest("Error Occured");
            }
            return Ok(_json.json("success", _health.Insert(obj)));
        }
        // PUT api/values/5
      
        public IHttpActionResult Put([FromBody]HealthNotesModel obj)
        {
            if (obj==null)
            {
                return BadRequest("Error Occured");
            }
            return Ok(_json.json("Updated successfully", _health.Update(obj)));
        }
        // DELETE api/values/5
        public IHttpActionResult Delete(int id)
        {
            if (id==0)
            {
                return BadRequest("Error Occured");
            }
            var obj = _health.GetById(id);
            if (obj==null)
            {
                return NotFound();
            }
            return Ok(_json.json("Success", _health.Delete(id)));
        }
    }
}
