using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u21529664_HW04.Models
{
    public abstract class Parent
    {
        public string CellphoneNumber { get; set; }

        public string EmailAddress { get; set; }

        public virtual void getContactDetails()
        {

            Console.WriteLine("Contact parent on:" + CellphoneNumber + "," + EmailAddress);
        }


    }
}