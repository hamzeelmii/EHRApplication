using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EHRApplication.Models
{
    public class Doctor
    {
       
        public int DoctorID { get; set; }

        public String FirstName { get; set; }
        public String LastName { get; set; }

        public int LoginID { get; set; }

      

        public ICollection<Patient> Patients { get; set; }

    }

  

   
}
