using HospitalAtHome.App.Controller;
using HospitalAtHome.App.Model.AppData;
using HospitalAtHome.App.Model.AppRepository.RepMedical;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HospitalAtHome.App.FrontEnd.Pages
{
    public class ListMedicalsModel : PageModel
    {
        public readonly IRepositoryMedical iRepositoryMedical;

        public IEnumerable<Medical> medicals;

        public ListMedicalsModel(IRepositoryMedical iRepositoryMedical)
        {
            this.iRepositoryMedical = iRepositoryMedical;
        }

        public void OnGet()
        {
            medicals = iRepositoryMedical.getAllMedical();
        }
    }
}
