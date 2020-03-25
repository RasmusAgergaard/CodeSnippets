using CustomUser.Areas.Identity.Data;
using CustomUser.Core;
using System.Collections.Generic;

namespace CustomUser.Data
{
    public interface IProjectData
    {
        public Project New(Project newProject, string userId);
        public List<Project> GetAll(string userId);
        public Project GetById(int id);
        public Project Update(Project updatedProject);
        public int Commit();
    }
}
