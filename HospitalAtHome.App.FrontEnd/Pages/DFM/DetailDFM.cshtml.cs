using HospitalAtHome.App.Controller;
using HospitalAtHome.App.Model.AppRepository.RepDesignatedFamilyMember;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HospitalAtHome.App.FrontEnd.Pages
{
    public class DetailDFMModel : PageModel
    {
        private readonly IRepositoryDesignatedFamilyMember repositoryDesignatedFamilyMember;
        public Medical medical { get; set;}
        public DetailDFMModel(IRepositoryDesignatedFamilyMember repositoryDesignatedFamily)
        {
            this.repositoryDesignatedFamilyMember = repositoryDesignatedFamily;
        }
        public void OnGet(int code)
        {
            //medical=repositoryDesignatedFamilyMember.getDesignatedFamilyMember(code);
        }
    }
}
