using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebService.MVC3.Controllers
{
    public class ServiceController : Controller
    {
        public JsonResult ToUpper(string input)
        {
            return Json(input.ToUpper(), JsonRequestBehavior.AllowGet);
        }

    }
}
