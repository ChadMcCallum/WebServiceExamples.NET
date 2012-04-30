using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;

namespace WebService.Nancy
{
    public class Service : NancyModule
    {
        public Service()
        {
            Get["/Echo/{input}"] = x => Echo(x.input);
        }

        private Response Echo(string input)
        {
            return Response.AsJson(input);
        }
    }
}