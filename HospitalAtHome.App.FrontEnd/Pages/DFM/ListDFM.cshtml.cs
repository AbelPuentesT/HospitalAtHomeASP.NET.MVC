using HospitalAtHome.App.Controller;
using HospitalAtHome.App.Model.AppRepository.RepDesignatedFamilyMember;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HospitalAtHome.App.FrontEnd.Pages
{
    public class ListDFMModel : PageModel
    {
        private readonly IRepositoryDesignatedFamilyMember repositoryDesignatedFamilyMember;
        public IEnumerable<DesignatedFamilyMember> designatedFamilyMembers;
        public ListDFMModel(IRepositoryDesignatedFamilyMember repositoryDesignatedFamilyMember)
        {
            this.repositoryDesignatedFamilyMember = repositoryDesignatedFamilyMember;
        }
        public void OnGet()
        {
            designatedFamilyMembers=repositoryDesignatedFamilyMember.getAllDesignatedFamilyMember();
        }
    }
}
