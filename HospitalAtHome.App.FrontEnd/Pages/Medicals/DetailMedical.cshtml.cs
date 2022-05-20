using HospitalAtHome.App.Controller;
using HospitalAtHome.App.Model.AppRepository.RepMedical;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HospitalAtHome.App.FrontEnd.Pages
{
    public class DetailMedicalModel : PageModel
    {
        private readonly IRepositoryMedical repositoryMedical;

        public Medical medical { get; set; }

        public DetailMedicalModel(IRepositoryMedical repositoryMedical)
        {
            this.repositoryMedical = repositoryMedical;
        }

        public void OnGet(int code)
        {
            medical = repositoryMedical.getMedical(code);
        }
    }
}
