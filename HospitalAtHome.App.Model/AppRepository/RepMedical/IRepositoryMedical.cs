using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HospitalAtHome.App.Controller;

namespace HospitalAtHome.App.Model.AppRepository.RepMedical
{
    public interface IRepositoryMedical
    {
        IEnumerable<Medical> getAllMedical();
        Medical getMedical(int code);
        Medical addMedical(Medical medical);
        Medical editMedical(Medical medical);
        void removeMedical(int code);
    }
}