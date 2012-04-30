using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceStack.ServiceInterface;

namespace WebService.ServiceStack
{
    public class Service : ServiceBase<Request>
    {
        protected override object Run(Request request)
        {
            return new Response() { Output = request.Input};
        }
    }
}