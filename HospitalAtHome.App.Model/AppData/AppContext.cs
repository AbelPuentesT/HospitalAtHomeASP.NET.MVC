using System;
using HospitalAtHome.App.Controller;
using Microsoft.EntityFrameworkCore;

namespace HospitalAtHome.App.Model.AppData
{
    public class AppContext: DbContext
    {
        public DbSet<DesignatedFamilyMember>? DesignatedFamilyMembers { get; set; }
        public DbSet<Medical>? Medicals { get; set; }
        public DbSet<MedicalRecord>? MedicalRecords { get; set; }
        public DbSet<Nurse>? Nurses { get; set; }
        public DbSet<Patient>? Patients { get; set; }
        public DbSet<Person>? Persons { get; set; }
        public DbSet<Suggestion>? Suggestions { get; set; }
        public DbSet<VitalSign>? VitalSigns { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder opciones)
        {
            if (!opciones.IsConfigured)
            {
                opciones
                    .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog=HospitalAtHome");
            }
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Person>().HasIndex(u => u.Id).IsUnique();
        }
    }
}