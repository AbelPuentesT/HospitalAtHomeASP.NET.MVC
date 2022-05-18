using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HospitalAtHome.App.Controller;
using HospitalAtHome.App.Model.AppData;

namespace HospitalAtHome.App.Model.AppRepository.RepNurse
{
    public class RepositoryNurse : IRepositoryNurse
    {
        private readonly myAppContext context;
        public RepositoryNurse(myAppContext context)
        {
            this.context = context;
        }

        public Nurse addNurse(Nurse nurse)
        {
            var newNurse = context.Add(nurse).Entity;
            context.SaveChanges();
            return newNurse;
        }

        public void deleteNurse(int code)
        {
            var FindNurse = context.Nurses.FirstOrDefault(n => n.Code == code);
            if (FindNurse != null)
            {
                context.Nurses.Remove (FindNurse);
                context.SaveChanges();
            }
        }

        public Nurse editNurse(Nurse nurse)
        {
            var FindNurse =
                context.Nurses.FirstOrDefault(n => n.Code == nurse.Code);
            if (FindNurse != null)
            {
                FindNurse.Name = nurse.Name;
                FindNurse.LastName = nurse.LastName;
                FindNurse.PhoneNumber = nurse.PhoneNumber;
                FindNurse.ProfessionalCard = nurse.ProfessionalCard;
                FindNurse.WorkingHours = nurse.WorkingHours;
            }
            context.SaveChanges();
            return FindNurse;
        }

        public IEnumerable<Nurse> getAllNurse()
        {
            return context.Nurses;
        }

        public Nurse getNurse(int code)
        {
            var FindNurse = context.Nurses.FirstOrDefault(n => n.Code == code);
            return FindNurse;
        }
    }
}
