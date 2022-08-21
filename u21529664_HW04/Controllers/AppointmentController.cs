using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace u21529664_HW04.Controllers
{
    public class AppointmentController : Controller
    {
        // GET: Appointment
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult BookAppointment()
        {
            return View();
        }
        public ActionResult ViewBooking()
        {
            return View();
        }
    }
}