﻿using System.Collections.Generic;
using TaskingBoss.Core;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace TaskingBoss.Data
{
    public class SqlTaskData : ITaskData
    {
        private readonly TaskingBossDbContext _db;

        public SqlTaskData(TaskingBossDbContext db)
        {
            _db = db;
        }

        public TaskItem Add(TaskItem newTask)
        {
            _db.Tasks.Add(newTask);
            return newTask;
        }

        public int Commit()
        {
            return _db.SaveChanges();
        }

        public TaskItem Delete(int id)
        {
            var task = GetById(id);

            if (task != null)
            {
                _db.Tasks.Remove(task);
            }

            return task;
        }

        public TaskItem GetById(int id)
        {
            return _db.Tasks.Find(id);
        }

        public int GetCountOfTasks()
        {
            return _db.Tasks.Count();
        }

        public IEnumerable<TaskItem> GetTaskByName(string name)
        {
            var query = from t in _db.Tasks
                        where string.IsNullOrEmpty(name) || t.Title.StartsWith(name)
                        orderby t.Title
                        select t;

            return query;
        }

        public List<TaskItem> GetTasks()
        {
            return _db.Tasks.ToList();
        }

        public IEnumerable<TaskItem> GetTasks(TaskStatus status)
        {
            var foundTasks = new List<TaskItem>();

            switch (status)
            {
                case TaskStatus.Backlog:
                    var backlog = (from t in _db.Tasks
                                    where t.Status == TaskStatus.Backlog
                                    select t).OrderByDescending(t => t.Priority);
                    foundTasks = backlog.ToList();
                    break;
                case TaskStatus.Sprint:
                    var sprint = (from t in _db.Tasks
                                    where t.Status == TaskStatus.Sprint
                                    select t).OrderByDescending(t => t.Priority);
                    foundTasks = sprint.ToList();
                    break;
                case TaskStatus.Doing:
                    var doing = (from t in _db.Tasks
                                    where t.Status == TaskStatus.Doing
                                    select t).OrderByDescending(t => t.Priority);
                    foundTasks = doing.ToList();
                    break;
                case TaskStatus.Blocked:
                    var blocked = (from t in _db.Tasks
                                    where t.Status == TaskStatus.Blocked
                                    select t).OrderByDescending(t => t.Priority);
                    foundTasks = blocked.ToList();
                    break;
                case TaskStatus.QA:
                    var qa = (from t in _db.Tasks
                                where t.Status == TaskStatus.QA
                                select t).OrderByDescending(t => t.Priority); ;
                    foundTasks = qa.ToList();
                    break;
                case TaskStatus.Done:
                    var done = (from t in _db.Tasks
                                where t.Status == TaskStatus.Done
                                select t).OrderByDescending(t => t.Priority);
                    foundTasks = done.ToList();
                    break;
                default:
                    break;
            }

            return foundTasks;
        }

        public TaskItem Update(TaskItem updatedTask)
        {
            //Attach the updated item to the db, so it monitors the changes. Then tell ef that the states is modified. This updates the item in the db
            var entity = _db.Tasks.Attach(updatedTask);
            entity.State = EntityState.Modified;

            return updatedTask;
        }
    }
}
