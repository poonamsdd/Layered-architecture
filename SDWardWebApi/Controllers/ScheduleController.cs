using SDWard.Service.Services.Schedule;
using SDWardWebApi.Filters;
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
   // [CustomFilter]
    public class ScheduleController : ApiController
    {
        private readonly IScheduleService _obj;
        private readonly JSON jobj;
        public ScheduleController(IScheduleService depobj, JSON _jobj)
        {
            this._obj = depobj;
            this.jobj = _jobj;
        }
        //JSON jobj = new JSON();
        // GET api/values
        public IHttpActionResult Get()
        {
            return Ok(jobj.json("Success", _obj.GetList()));
        }
        // GET api/values/5
        public IHttpActionResult Get(int id)
        {
            if (id == 0)
            {
                return BadRequest("Error Occured");
            }
            var obj = _obj.GetById(id);
            if (obj == null)
            {
                return NotFound();
            }

            return Ok(jobj.json("Success", obj));
        }
        // POST api/values
        [HttpPost]
        public IHttpActionResult Post([FromBody]PatientScheduleModel sobj)
        {
            if (sobj == null)
            { 
                return BadRequest("Error Occured");
            }
            return Ok(jobj.json("Success", _obj.Insert(sobj)));

        }
        // PUT api/values/5
        public IHttpActionResult Put([FromBody]PatientScheduleModel sobj)
        {
            if (sobj == null)
            {
                return BadRequest("Error Occured");
            }
            return Ok(jobj.json("success", _obj.Update(sobj)));

        }
        // DELETE api/values/5
        public IHttpActionResult Delete(int id)
        {
            if (id == 0)
            {
                return BadRequest("Error Occured");
            }
            var obj = _obj.GetById(id);
            if (obj == null)
            {
                return BadRequest("Id not found");
            }
            return Ok(jobj.json("Record deleted", _obj.Delete(id)));
        }
    }
}

