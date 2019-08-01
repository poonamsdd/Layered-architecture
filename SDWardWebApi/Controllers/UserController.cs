using System;
using ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SDWard.Service.Services.User;
using SDWardWebApi.Filters;
using SDWardWebApi.Helper;

namespace SDWardWebApi.Controllers
{
    [CustomFilter]
    public class UserController : ApiController
    {
        
        private readonly IUserService _obj;
        private readonly JSON _json;
        public UserController(IUserService obj,JSON json)
        {
            _json = json;
            this._obj = obj;
        }
        // GET api/User
        public IHttpActionResult Get()
        {
            return Ok(_json.json("Success",_obj.GetList()));
        }

        // GET api/User/5
        public IHttpActionResult Get(int id)
        {
            if (id==0)
            {
                return BadRequest("Error Occured");
            }
            var obj = _obj.GetUserId(id);
            if (obj==null)
            {
                 return NotFound();
;
            }
            return Ok(_json.json("Success",_obj.GetUserId(id)));
        }

        // POST api/User
        [HttpPost]
        public IHttpActionResult Post([FromBody]UserModel model)
        {
            if (model == null)
            {
                return BadRequest("Error Occoured");
            }
            return Ok(_json.json("Success",_obj.Update(model)));
        }

        // PUT api/User/5
        public IHttpActionResult Put(int id, [FromBody]UserModel model)        
        {
            if (model==null)
            {
                return BadRequest("Error Occoured");
            }
            return Ok(_json.json("Success",_obj.Update(model)));
        }

        // DELETE api/User/5
        public IHttpActionResult Delete(int id)
        {
            if (id == 0)
            {
                return BadRequest("Error Occured");
            }
            var obj = _obj.GetUserId(id);
            if (obj == null)
            {
                return BadRequest("Id not found");
            }
            return Ok(_obj.Delete(id));
        }
        
    }
}
