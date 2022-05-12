using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HospitalAtHome.App.Controller;

namespace HospitalAtHome.App.Model.AppRepository.RepNurse
{
    public interface IRepositoryNurse
    {
        IEnumerable<Nurse> getAllNurse();
        Nurse getNurse(int code);
        Nurse addNurse(Nurse nurse);
        Nurse editNurse(Nurse nurse);
        void deleteNurse(int code);

    }
}