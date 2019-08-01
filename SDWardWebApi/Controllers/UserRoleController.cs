using SDWard.Entity.Entities;
using SDWard.Service.Services.UserRole;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ViewModels;

namespace SDWardWebApi.Controllers
{
    public class UserRoleController : ApiController
    {
        private readonly IRoleService _obj;
        public UserRoleController(IRoleService obj)
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
           
            return Ok(_obj.GetRoleId(id));
        }
        // POST api/values
        [HttpPost]
        public IHttpActionResult Post([FromBody]UserRoleModel sobj)
        {
           return Ok( _obj.InsertRole(sobj));           
        }
        // PUT api/values/5
        public IHttpActionResult Put([FromBody]UserRoleModel sobj)
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
