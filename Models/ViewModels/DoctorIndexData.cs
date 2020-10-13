using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EHRApplication.Models;

namespace EHRApplication.ViewModels
{
    public class DoctorIndexData
    {
        public IEnumerable<Doctor> Doctors { get; set; }
        public IEnumerable<Patient> Patients { get; set; }
    }
    


}
