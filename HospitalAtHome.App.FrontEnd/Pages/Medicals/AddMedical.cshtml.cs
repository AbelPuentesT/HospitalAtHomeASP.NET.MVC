using HospitalAtHome.App.Controller;
using HospitalAtHome.App.Model.AppRepository.RepMedical;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HospitalAtHome.App.FrontEnd.Pages
{
    public class AddMedicalModel : PageModel
    {
        private readonly IRepositoryMedical iRepositoryMedical;
        public Medical newMedical { get; set; }
        public AddMedicalModel(IRepositoryMedical iRepositoryMedical)
        {
            this.iRepositoryMedical = iRepositoryMedical;
        }
        public void OnGet()
        {
            newMedical= new Medical(); 
        }
        public IActionResult OnPost(Medical newMedical)
        {
            try{
                iRepositoryMedical.addMedical(newMedical);
                return RedirectToPage("./ListMedicals");
            }
            catch{
                return RedirectToPage("../Error");
            }
        }
    }
}
