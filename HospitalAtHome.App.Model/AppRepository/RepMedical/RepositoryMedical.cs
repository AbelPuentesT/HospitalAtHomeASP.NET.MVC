using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HospitalAtHome.App.Controller;
using HospitalAtHome.App.Model.AppData;

namespace HospitalAtHome.App.Model.AppRepository.RepMedical
{
    public class RepositoryMedical : IRepositoryMedical
    {
        private readonly myAppContext? context;

        public RepositoryMedical(myAppContext context)
        {
            this.context = context;
        }

        public Medical addMedical(Medical medical)
        {
            Medical newMedical = context.Add(medical).Entity;
            context.SaveChanges();
            return newMedical;
        }

        public Person Create(Person person)
        {
            throw new NotImplementedException();
        }

        public Person Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Medical editMedical(Medical medical)
        {Medical FindMedical =
                context.Medicals.FirstOrDefault(m => m.Code == medical.Code);
                if (FindMedical != null)
                {
                    FindMedical.Name=medical.Name;
                    FindMedical.LastName=medical.LastName;
                    FindMedical.PhoneNumber=medical.PhoneNumber;
                    FindMedical.Registration=medical.Registration;
                    FindMedical.Specialty=medical.Specialty;
                }
                context.SaveChanges();
                return FindMedical;
        }

        public IEnumerable<Person> GetAll()
        {
            return context.Medicals;
        }

        public IEnumerable<Medical> getAllMedical()
        {
            return context.Medicals;
        }

        public Person GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Medical getMedical(int code)
        {
            Medical FindMedical =
                context.Medicals.FirstOrDefault(m => m.Code == code);
            context.SaveChanges();
            return FindMedical;
        }

        public void removeMedical(int code)
        {
            Medical FindMedical =
                context.Medicals.FirstOrDefault(m => m.Code == code);
            if (FindMedical != null)
            {
                context.Medicals.Remove (FindMedical);
                context.SaveChanges();
            }
        }

        public Person Update(Person person)
        {
            throw new NotImplementedException();
        }
    }
}
