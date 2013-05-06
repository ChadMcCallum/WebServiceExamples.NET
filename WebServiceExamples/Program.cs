using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebServiceExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new asmxService.WebService1();
            service.Url = "http://localhost.:54929/WebService1.asmx";
            Console.WriteLine(service.ToUpper("Hello World"));

            var service2 = new wcfService.Service1Client();
            Console.WriteLine(service2.ToUpper("Hello World"));

            Console.ReadLine();
        }
    }
}
