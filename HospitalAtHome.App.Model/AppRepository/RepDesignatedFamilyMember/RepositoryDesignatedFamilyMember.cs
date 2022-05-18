using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HospitalAtHome.App.Controller;
using HospitalAtHome.App.Model.AppData;

namespace HospitalAtHome.App.Model.AppRepository.RepDesignatedFamilyMember
{
    public class RepositoryDesignatedFamilyMember : IRepositoryDesignatedFamilyMember
    {
        private readonly myAppContext? context;
        public RepositoryDesignatedFamilyMember (myAppContext? context)
        {
            this.context = context;
        }
        public DesignatedFamilyMember addDesignatedFamilyMember(DesignatedFamilyMember dfm)
        {
            var newDfm= context.Add(dfm).Entity;
            context.SaveChanges();
            return  newDfm;
        }

        public DesignatedFamilyMember editDesignatedFamilyMember(DesignatedFamilyMember dfm)
        {
            var findDfm= context.DesignatedFamilyMembers.FirstOrDefault(dfm => dfm.Code == dfm.Code);
            findDfm.Name = dfm.Name;
            findDfm.LastName = dfm.LastName;
            findDfm.PhoneNumber = dfm.PhoneNumber;
            findDfm.Relationship = dfm.Relationship;
            findDfm.Email = dfm.Email;
            findDfm.Gender = dfm.Gender;
            context.SaveChanges();
            return findDfm;
        }

        public IEnumerable<DesignatedFamilyMember> getAllDesignatedFamilyMember()
        {
            context.SaveChanges();
            return context.DesignatedFamilyMembers;
        }

        public DesignatedFamilyMember getDesignatedFamilyMember(int code)
        {
            var findDfm= context.DesignatedFamilyMembers.FirstOrDefault(dfm => dfm.Code == code);
            context.SaveChanges();
            return findDfm;
        }

        public void removeDesignatedFamilyMember(int code)
        {
            var findDfm= context.DesignatedFamilyMembers.FirstOrDefault(dfm => dfm.Code == code);
            if (findDfm != null)
            {
                context.DesignatedFamilyMembers.Remove(findDfm);
            }
            context.SaveChanges();
        }
    }
}