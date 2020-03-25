﻿using System.Collections.Generic;
using TaskingBoss.Core;

namespace TaskingBoss.Data
{
    public interface ITaskData
    {
        IEnumerable<TaskItem> GetTaskByName(string name);
        TaskItem GetById(int id);
        List<TaskItem> GetTasks();
        IEnumerable<TaskItem> GetTasks(TaskStatus status);
        TaskItem Update(TaskItem updatedTask);
        TaskItem Add(TaskItem newTask);
        TaskItem Delete(int id);
        int GetCountOfTasks();
        int Commit();
    }
}
