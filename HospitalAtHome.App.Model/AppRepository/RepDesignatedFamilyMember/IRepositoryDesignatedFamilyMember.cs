using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HospitalAtHome.App.Controller;

namespace HospitalAtHome.App.Model.AppRepository.RepDesignatedFamilyMember
{
    public interface IRepositoryDesignatedFamilyMember
    {
        IEnumerable<DesignatedFamilyMember> getAllDesignatedFamilyMember();
        DesignatedFamilyMember getDesignatedFamilyMember(int code);
        DesignatedFamilyMember addDesignatedFamilyMember(DesignatedFamilyMember dfm);
        DesignatedFamilyMember editDesignatedFamilyMember(DesignatedFamilyMember dfm);
        void removeDesignatedFamilyMember(int code);
    }
}