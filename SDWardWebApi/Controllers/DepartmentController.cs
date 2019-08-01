using SDWard.Service.Services.Department;
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
    public class DepartmentController : ApiController
    {
        private readonly IDeptService _depobj;
        private readonly JSON jobj;
        public DepartmentController(IDeptService depobj,JSON _jobj)
        {
            this._depobj = depobj;
            this.jobj = _jobj;
        }
        //JSON jobj = new JSON();
        // GET api/values
        public IHttpActionResult Get()
        {       
            return Ok(jobj.json("Success",_depobj.GetList()));           
        }
        // GET api/values/5
        public IHttpActionResult Get(int id)
        {
            if (id == 0)
            {
                return BadRequest("Error Occured");
            }
            var obj = _depobj.GetDeptId(id);
            if (obj == null)
            {
                return NotFound();
            }

            return Ok(jobj.json("Success",_depobj.GetDeptId(id)));
        }
        // POST api/values
        [HttpPost]
        public IHttpActionResult Post([FromBody]DepartmentModel sobj)
        {
            if (sobj ==null)
            {
                return BadRequest("Error Occured");
            }
            return Ok(jobj.json("Success",_depobj.InsertDept(sobj)));
           
        }
        // PUT api/values/5
        public IHttpActionResult Put([FromBody]DepartmentModel sobj)
        {
            if (sobj==null)
            {
                return BadRequest("Error Occured");
            }
            return Ok(jobj.json("success",_depobj.Update(sobj)));

        }
        // DELETE api/values/5
        public IHttpActionResult Delete(int id)
        {
            if (id ==0)
            {
                return BadRequest("Error Occured");
            }
            var obj = _depobj.GetDeptId(id);
            if (obj==null)
            {
                return BadRequest("Id not found");
            }
            return Ok(jobj.json("Record deleted",_depobj.Delete(id)));           
        }
    }
}
