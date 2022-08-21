using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u21529664_HW04.Models
{
    class MedicalConditions
    {
        public virtual void getMedicalDetails()
        {
            Console.WriteLine("Have vaccinated");
        }

    }
    class Baby : MedicalConditions  // Derived class (child) 
    {
        public override void getMedicalDetails()
        {
            Console.WriteLine("Is not fully Vaccinated");
        }
    }
    class Mother : MedicalConditions  // Derived class (child) 
    {
        public override void getMedicalDetails()
        {
            Console.WriteLine("Is fully vaccinated");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MedicalConditions myMedicalCondition = new MedicalConditions();
            Baby myBaby = new Baby();  
            Mother myMother = new Mother();  

            myMedicalCondition.getMedicalDetails();
            myBaby.getMedicalDetails();
            myMother.getMedicalDetails();
        }
    }
}