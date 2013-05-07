using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceStack.ServiceHost;

namespace WebService.ServiceStack
{
    [Route("/ToUpper/{input}")]
    public class Request : IReturn<Response>
    {
        public string Input { get; set; }
    }
}