using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ViewModels;

namespace SDWardWebApi.Helper
{
    public class TokenGenerator
    {
        public static object Session { get; set; }
        public static string Token { get; set; }
        public static string GetToken(UserModel user)
        {
            Session = user;
            Random random = new Random();
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Token = new string(Enumerable.Repeat(chars, 10)
              .Select(s => s[random.Next(s.Length)]).ToArray());
            return Token;
        }
    }
}