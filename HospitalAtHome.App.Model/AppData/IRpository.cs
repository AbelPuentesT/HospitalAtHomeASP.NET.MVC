using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HospitalAtHome.App.Controller;

namespace HospitalAtHome.App.Model.AppData
{
    public interface IRpository
    {
        IEnumerable<Person> GetAll();
        Person GetById(int id);
        Person Create(Person person);
        Person Update(Person person);
        Person Delete(int id);
    }
}