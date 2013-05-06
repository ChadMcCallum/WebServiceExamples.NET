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
            Get["/ToUpper/{input}"] = x => ToUpper(x.input);
        }

        private Response ToUpper(string input)
        {
            return Response.AsJson(input.ToUpper());
        }
    }
}