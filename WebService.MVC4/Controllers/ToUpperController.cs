using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace WebService.MVC4.Controllers
{
    public class ToUpperController : ApiController
    {
        public string Get(string input)
        {
            return input.ToUpper();
        }
        
    }
}
