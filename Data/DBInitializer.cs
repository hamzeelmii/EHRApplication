using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using EHRApplication.Models;
using EHRApplication.Data;

namespace EHRApplication.Models

{
    public class DBInitializer
    {
        public static void Initialize(EHRApplicationContext context)
        {

            context.Database.EnsureCreated();

            

            if (context.Doctors.Any())
            {
                return; //DB has been seeded
            }

            
            //context.Doctors.Identity

            var doctors = new Doctor[]
            //DoctorID = 0,
            {
            new Doctor { FirstName = "Javale", LastName = "McGee", LoginID=1234 },
            new Doctor {  FirstName = "Shaqtin", LastName = "A'Fool" , LoginID = 4567 },
            new Doctor { FirstName = "Kendrick", LastName = "Perkins", LoginID =8888}

            };

            context.Doctors.AddRange(doctors);
            context.SaveChanges();

            var patients = new Patient[]
            {
                //
                //PatientID = 0,
            new Patient {  DoctorID=doctors.Single(i => i.LastName == "McGee").DoctorID, FirstName = "Jason", LastName = "Derulo", BirthDate = DateTime.Parse("2000-08-01"), HealthCardNum = 12345678 },
            new Patient {  DoctorID=doctors.Single(i => i.LastName == "McGee").DoctorID, FirstName = "Lebron", LastName = "Curry", BirthDate = DateTime.Parse("1987-02-05"), HealthCardNum = 11110123 },
            new Patient {   DoctorID=doctors.Single(i => i.LastName == "A'Fool").DoctorID, FirstName = "Tragic", LastName = "Bronson", BirthDate = DateTime.Parse("2011-01-31"), HealthCardNum = 11114567 },
            new Patient {  DoctorID=doctors.Single(i => i.LastName == "A'Fool").DoctorID, FirstName = "Sb", LastName = "Dunks", BirthDate = DateTime.Parse("2001-07-15"), HealthCardNum = 11110000 },
            new Patient { DoctorID=doctors.Single(i => i.LastName == "Perkins").DoctorID, FirstName = "Jermaine", LastName = "Lamar", BirthDate = DateTime.Parse("1978-05-12"), HealthCardNum = 11112222 }


            };

            context.Patients.AddRange(patients);
            context.SaveChanges();


            /* foreach (Patient p in patients)
            {
                var patientInDataBase = context.Patients.Where(
                    pa =>
                            pa.Doctor.DoctorID == p.DoctorID).SingleOrDefault();

                if (patientInDataBase == null)
                {
                    context.Patients.Add(p);
                }
            }
            */
            
        

        }
        }

    }


