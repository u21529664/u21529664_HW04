using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace u21529664_HW04.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        public ActionResult RegisterParent()
        {
            return View();
        }
        public ActionResult RegisterChild()
        {
            return View();
        }
    }
}