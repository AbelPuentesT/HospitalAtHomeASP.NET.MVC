using HospitalAtHome.App.Controller;
using HospitalAtHome.App.Model.AppRepository.RepMedical;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HospitalAtHome.App.FrontEnd.Pages
{
    public class EditMedicalsModel : PageModel
    {
        private readonly IRepositoryMedical iRepositoryMedical;
        public Medical medical { get; set; }
        public EditMedicalsModel(IRepositoryMedical iRepositoryMedical)
        {
            this.iRepositoryMedical = iRepositoryMedical;
        }
        public void OnGet(int Id)
        {
            //medical=new Medical();
            medical= iRepositoryMedical.getMedical(Id);
        }
        public IActionResult OnPost(Medical medical)
        {
            try{
                iRepositoryMedical.editMedical(medical);
                return RedirectToPage("./ListMedicals");
            }catch{
                return RedirectToPage("../Error");
            }
        }
    }
}
