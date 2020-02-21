using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomUser.Core;
using Microsoft.AspNetCore.Identity;

namespace CustomUser.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        //public override string Id { get; set; }

        [PersonalData]
        public string Name { get; set; }
        [PersonalData]
        public DateTime DOB { get; set; }

        public ICollection<ApplicationUserProjects> ApplicationUserProjects { get; } = new List<ApplicationUserProjects>();
    }
}
