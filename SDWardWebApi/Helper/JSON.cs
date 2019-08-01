using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ViewModels;

namespace SDWardWebApi.Helper
{
    public class JSON
    {
        public JSON()
        {
                
        }
        public JSONModel json(string str, Object data) 
        {
            return new JSONModel()
            {
                Status = str,
                Data = data,
                TimeStamp = DateTime.Now
            };
        }
    }
}