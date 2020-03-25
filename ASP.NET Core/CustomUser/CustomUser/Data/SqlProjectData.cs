using CustomUser.Areas.Identity.Data;
using CustomUser.Core;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace CustomUser.Data
{
    public class SqlProjectData : IProjectData
    {
        private readonly CustomUserContext _db;

        public SqlProjectData(CustomUserContext db)
        {
            _db = db;
        }

        public Project New(Project newProject, string userId)
        {
            _db.Projects.Add(newProject);
            _db.ApplicationUserProjects.Add(new ApplicationUserProjects { Id = userId, Project = newProject });
            return newProject;
        }

        public int Commit()
        {
            return _db.SaveChanges();
        }

        public List<Project> GetAll(string userId)
        {
            var result = new List<Project>();

            foreach (var item in _db.ApplicationUserProjects)
            {
                if (item.Id == userId)
                {
                    result.Add(GetById(item.ProjectId));
                }
            }

            return result;
        }

        public Project GetById(int id)
        {
            return _db.Projects.Find(id);
        }

        public Project Update(Project updatedProject)
        {
            //Attach the updated item to the db, so it monitors the changes. Then tell ef that the states is modified. This updates the item in the db
            var entity = _db.Projects.Attach(updatedProject);
            entity.State = EntityState.Modified;

            return updatedProject;
        }
    }
}
