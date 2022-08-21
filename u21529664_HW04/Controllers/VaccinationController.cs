using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace u21529664_HW04.Controllers
{
    public class VaccinationController : Controller
    {
        // GET: Vaccination
        public ActionResult AddVaccinationDetails()
        {
            return View();
        }
        public ActionResult ViewVaccinationDetails()
        {
            return View();
        }
    }
}