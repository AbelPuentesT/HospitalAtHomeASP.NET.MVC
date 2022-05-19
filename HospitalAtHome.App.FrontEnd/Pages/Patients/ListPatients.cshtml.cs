using HospitalAtHome.App.Controller;
using HospitalAtHome.App.Model.AppRepository.RepPatient;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HospitalAtHome.App.FrontEnd.Pages
{
    public class ListPatientsModel : PageModel
    {
        private readonly IRepositoryPatient iRepositoryPatient;
        public IEnumerable<Patient> patients;
        public ListPatientsModel(IRepositoryPatient iRepositoryPatient)
        {
            this.iRepositoryPatient = iRepositoryPatient;
        }
        public void OnGet()
        {
            patients = iRepositoryPatient.GetAllPatient();
        }
    }
}
