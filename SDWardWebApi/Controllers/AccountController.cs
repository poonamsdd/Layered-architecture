using SDWard.Service.Services.User;
using SDWard.Service.Services.Veification;
using SDWardWebApi.Filters;
using SDWardWebApi.Helper;
using SDWardWebApi.Helper.Email;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ViewModels;

namespace SDWardWebApi.Controllers
{
    public class AccountController : ApiController
    {
        private readonly IUserService _user;
        //private readonly JSON _json;
        private readonly IVerifyService _verify;

        public AccountController(IUserService user, IVerifyService verify)
        {
            _user = user;
            _verify = verify;
        }

        [HttpPost]
        [Route("api/Account/Login")]
        public HttpResponseMessage Login([FromBody]LoginModel value)
        {
            JSON _json = new JSON();
            if (!ModelState.IsValid)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, _json.json("Wrong Params", null));
            }
            var obj = _user.LoginUser(value);
            if (obj == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, _json.json("check your email and password", null));
            }
            if (obj.VarifyBit)
            {
                return Request.CreateResponse(HttpStatusCode.OK, _json.json("Success", new { Token = TokenGenerator.GetToken(obj) }));
            }
            VerificationCode(value.Email);
            return Request.CreateResponse(HttpStatusCode.OK, _json.json("Verification Failed", new { Verify = " not Verified Check Your Mail  Verification Code" }));
        }
        [HttpPost]
        [Route("api/Account/Register")]
        public HttpResponseMessage Register([FromBody]UserModel obj)
        {
            JSON _json = new JSON();
            if (!ModelState.IsValid)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, _json.json("Wrong enteries", null));
            }
            obj.VarifyBit = false;
            var obj1 = _user.InsertUser(obj);
            if (obj1 == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, _json.json("something went wrong", null));
            }
            VerificationCode(obj.Email);
            return Request.CreateResponse(HttpStatusCode.OK, _json.json("Success", obj1));
        }
        [HttpPost]
        [Route("api/Account/Verify")]
        public HttpResponseMessage Verify([FromBody]VerifyModel verify)
        {
            JSON _json = new JSON();
            if (!ModelState.IsValid)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, _json.json("Wrong Params", null));
            }
            var obj = _verify.CompareCode(verify);
            return Request.CreateResponse(HttpStatusCode.OK, _json.json("Success", obj));
        }
        public void VerificationCode(string email)
        {
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random random = new Random();
            string code = new string(Enumerable.Repeat(chars, 15).
            Select(s => s[random.Next(s.Length)]).ToArray());
            _verify.AddVerification(new VerifyModel() { Email = email, ConfirmEmail = code });
            EmailSender.SendMail(email, "sdhealthcarepoonam@gmail.com", code);
        }
        [HttpPost]
        [Route("api/Account/Forget")]
        public HttpResponseMessage Forget(ForgetPasswordModel fmodel)
        {
            JSON _json = new JSON();
            ForgetPasswordModel obj1 = new ForgetPasswordModel();
            if (ModelState.IsValid)
            {
                obj1 = _user.ForgetUser(fmodel);
                if (obj1 == null)
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, _json.json("something went wrong", null));
                }
                VerificationCode(obj1.Email);
            }

            return Request.CreateResponse(HttpStatusCode.OK, _json.json("Success", obj1));
        }
        [HttpPost]
        [Route("api/Account/Reset")]
        public HttpResponseMessage Reset(ResetModel fmodel)
        {
            JSON _json = new JSON();
            if (!ModelState.IsValid)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, _json.json("Enter the required fields", null));

            }
            var obj = _verify.ResetCode(fmodel);
            if (obj==null)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, _json.json("Wrong enteries",null));
            }
            return Request.CreateResponse(HttpStatusCode.OK, _json.json("Success", obj));
        }
    }
}
