using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HospitalAtHome.App.Controller;

namespace HospitalAtHome.App.Model.AppRepository.RepPatient
{
    public interface IRepositoryPatient
    {
        IEnumerable<Patient> GetAllPatient();
        Patient GetPatient(int code);
        Patient AddPatient(Patient patient);
        void RemovePatient(int code);
        Patient editPatient(Patient patient);
    }
}