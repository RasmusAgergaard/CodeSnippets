using System;
using System.Collections.Generic;
using System.Text;

namespace CustomUser.Core
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public ICollection<ApplicationUserProjects> ApplicationUserProjects { get; } = new List<ApplicationUserProjects>();
    }
}
