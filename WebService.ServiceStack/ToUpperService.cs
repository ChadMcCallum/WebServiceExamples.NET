using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceStack.ServiceInterface;

namespace WebService.ServiceStack
{
    public class ToUpperService : Service
    {
        public Response Get(Request request)
        {
            return new Response {Output = request.Input.ToUpper()};
        }
    }
}