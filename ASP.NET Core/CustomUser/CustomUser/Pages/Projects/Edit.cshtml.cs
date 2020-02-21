using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using CustomUser.Areas.Identity.Data;
using CustomUser.Core;
using CustomUser.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CustomUser.Pages.Projects
{
    public class EditModel : PageModel
    {
        private readonly IProjectData _projectData;
        private readonly UserManager<ApplicationUser> _userManager;

        [BindProperty]
        public Project Project { get; set; }

        public EditModel(IProjectData projectData, UserManager<ApplicationUser> userManager)
        {
            _projectData = projectData;
            _userManager = userManager;
        }

        public IActionResult OnGet(int? projectId)
        {
            if (projectId.HasValue)
            {
                Project = _projectData.GetById(projectId.Value);
            }
            else
            {
                Project = new Project();
            }

            if (Project == null)
            {
                return RedirectToPage("./NotFound"); //TODO: Create this page
            }

            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (Project.ProjectId > 0)
            {
                _projectData.Update(Project);
                TempData["Message"] = "Project updated!";
            }
            else
            {
                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                _projectData.New(Project, userId);
                TempData["Message"] = "Project added!";
            }

            _projectData.Commit();
            return Page();
            //return RedirectToPage("./Detail", new { taskId = Project.ProjectId });
        }
    }
}
