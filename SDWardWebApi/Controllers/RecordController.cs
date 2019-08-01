using SDWard.Service.Services.Record;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ViewModels;

namespace SDWardWebApi.Controllers
{
    public class RecordController : ApiController
    {
        private readonly IRecordService _obj;
        public  RecordController(IRecordService obj)
        {
            this._obj = obj;
        }
        // GET api/values
        public IHttpActionResult Get()
        {
            return Ok(_obj.GetList());
        }

        // GET api/values/5
        public IHttpActionResult Get(int id)
        {

            return Ok(_obj.GetRecordId(id));
        }
        // POST api/values
        [HttpPost]
        public IHttpActionResult Post([FromBody]RecordModel sobj)
        {
            return Ok(_obj.Insert(sobj));
        }
        // PUT api/values/5
        public IHttpActionResult Put([FromBody]RecordModel sobj)
        {
            return Ok(_obj.Update(sobj));

        }
        // DELETE api/values/5
        //public IHttpActionResult Delete(int id)
        //{
        //    return Ok(_obj.Delete(id));
        //}
    }
}
