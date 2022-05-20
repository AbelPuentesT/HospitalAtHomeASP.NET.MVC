using HospitalAtHome.App.Controller;
using HospitalAtHome.App.Model.AppRepository.RepMedical;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HospitalAtHome.App.FrontEnd.Pages
{
    public class RemoveMedicalModel : PageModel
    {
        private readonly IRepositoryMedical iRepositoryMedical;
        public Medical medical { get; set; }
        public RemoveMedicalModel(IRepositoryMedical iRepositoryMedical)
        {
            this.iRepositoryMedical = iRepositoryMedical;
        }
        public void OnGet(int code)
        {
            medical= iRepositoryMedical.getMedical(code);
        }
        public IActionResult OnPost(int code)
        {
            try{
                iRepositoryMedical.removeMedical(code);
                return RedirectToPage("./ListMedicals");
            }
            catch{
                return RedirectToPage("../Error");
            }
        }
    }
}
