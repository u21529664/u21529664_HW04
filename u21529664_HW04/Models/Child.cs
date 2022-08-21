using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace u21529664_HW04.Models
{
     class Child // base class
     {
        public string Name { get; set; }

        public virtual void getChildDetails()
        { 

            Console.WriteLine("The baby is:" + Name);
        }
        
        

     }    
    //derived class
    class Age : Child
    {
        public int CurrentYear = 2022;
        public int BirthYear { get; set; }

        public virtual void getChildAge()
        {
            Console.WriteLine(CurrentYear - BirthYear);
        }
        public override void getChildDetails()
        {
            base.getChildDetails();

           
        }
       
       
    }

}
  
