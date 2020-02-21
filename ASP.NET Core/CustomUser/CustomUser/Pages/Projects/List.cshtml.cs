using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomUser.Core;
using CustomUser.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Identity;
using CustomUser.Areas.Identity.Data;
using System.Security.Claims;

namespace CustomUser.Pages.Projects
{
    public class ListModel : PageModel
    {
        private readonly IProjectData _projectData;
        private readonly UserManager<ApplicationUser> _userManager;

        public List<Project> Projects { get; set; }
        public string Id { get; set; }

        public ListModel(IProjectData projectData, UserManager<ApplicationUser> userManager)
        {
            _projectData = projectData;
            _userManager = userManager;
        }


        public void OnGet()
        {
            var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);

            Projects = _projectData.GetAll(userId);
        }

    }
}
