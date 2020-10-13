using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace EHRApplication.Models
{
    public class Patient
    {

        public int PatientID { get; set; }
        public int DoctorID { get; set; }
        public String FirstName { get; set; }

        public String LastName { get; set; }

        [Range(10000000,99999999)]
        public int HealthCardNum { get; set; }

        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        public Doctor Doctor { get; set; }




    }

    


}
