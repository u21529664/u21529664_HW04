using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u21529664_HW04.Models
{
    public abstract  class Booking
    {
        public string CellphoneNumber { get; set; }

        public DateTime DateAndTime { get; set; }

        public string Location { get; set; }

        public virtual void getAppointmentDetails()
        {

            Console.WriteLine("Appointment details:" + DateAndTime + "at" +"" + Location + ","+"contact" + "" +CellphoneNumber);
        }
    }
}