using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EHRApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace EHRApplication.Data
{
    public class EHRApplicationContext: DbContext
    {
        public EHRApplicationContext(DbContextOptions<EHRApplicationContext> options) : base(options)
        {
        }

        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Patient>().ToTable("Patient");
            modelBuilder.Entity<Doctor>().ToTable("Doctor");

            modelBuilder.Entity<Patient>()
            .HasOne<Doctor>(p => p.Doctor)
            .WithMany(d => d.Patients)
            .HasForeignKey(p => p.DoctorID);





        }
    }
}
