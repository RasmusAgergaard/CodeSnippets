using CustomUser.Areas.Identity.Data;
using System;
using System.Collections.Generic;
using System.Text;



namespace CustomUser.Core
{
    public class ApplicationUserProjects
    {
        public string Id { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

        public int ProjectId { get; set; }
        public Project Project { get; set; }

    }
}
