using HospitalAtHome.App.Controller;
using HospitalAtHome.App.Model.AppRepository.RepNurse;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HospitalAtHome.App.FrontEnd.Pages
{
    public class ListNursesModel : PageModel
    {
        private readonly IRepositoryNurse repositoryNurse;
        public IEnumerable<Nurse> nurses;
        public ListNursesModel(IRepositoryNurse repositoryNurse)
        {
            this.repositoryNurse = repositoryNurse;

        }
        public void OnGet()
        {
            nurses= repositoryNurse.getAllNurse();
        }
    }
}
