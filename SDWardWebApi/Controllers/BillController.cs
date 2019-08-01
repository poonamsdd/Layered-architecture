using SDWard.Service.Services.Bill;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ViewModels;

namespace SDWardWebApi.Controllers
{
    public class BillController : ApiController
    {
        private readonly IBillService _obj;
        public BillController(IBillService obj)
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

            return Ok(_obj.GetBillById(id));
        }
        // POST api/values
        [HttpPost]
        public IHttpActionResult Post([FromBody]BillingModel sobj)
        {
            return Ok(_obj.InsertBill(sobj));
        }
        // PUT api/values/5
        public IHttpActionResult Put([FromBody]BillingModel sobj)
        {
            return Ok(_obj.Update(sobj));

        }
        // DELETE api/values/5
        public IHttpActionResult Delete(int id)
        {
            return Ok(_obj.Delete(id));
        }
    }
}
