using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HospitalAtHome.App.Controller;
using HospitalAtHome.App.Model.AppData;

namespace HospitalAtHome.App.Model.AppRepository.RepPatient
{
    public class RepositoryPatient : IRepositoryPatient
    {
        private readonly myAppContext context;

        public Patient AddPatient(Patient patient)
        {
            var newPatient = context.Add(patient).Entity;
            context.SaveChanges();
            return newPatient;
        }

        public Patient editPatient(Patient patient)
        {
            var findPatient= context.Patients.FirstOrDefault(p => p.Code == patient.Code);
            if(findPatient != null)
            {
                findPatient.Name = patient.Name;
                findPatient.LastName = patient.LastName;
                findPatient.PhoneNumber = patient.PhoneNumber;
                findPatient.VitalSign = patient.VitalSign;
                findPatient.Address = patient.Address;
                findPatient.MedicalRecord = patient.MedicalRecord;
                findPatient.Medical = patient.Medical;
                findPatient.Gender = patient.Gender;
                findPatient.DesignatedFamilyMember = patient.DesignatedFamilyMember;
                findPatient.City = patient.City;
                findPatient.BirthDate = patient.BirthDate;
                findPatient.Address = patient.Address;
            }
            context.SaveChanges();
            return findPatient;
        }

        public IEnumerable<Patient> GetAllPatient()
        {
            context.SaveChanges();
            return context.Patients;
        }

        public Patient GetPatient(int code)
        {
            var findPatient =
                context.Patients.FirstOrDefault(p => p.Code == code);
            context.SaveChanges();
            return findPatient;
        }

        public void RemovePatient(int code)
        {
            var findPatient = context.Patients.FirstOrDefault(p=>p.Code== code);
            if(findPatient != null)
            {
                context.Patients.Remove(findPatient);
            }
            context.SaveChanges();
        }
    }
}
