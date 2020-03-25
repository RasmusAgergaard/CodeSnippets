﻿using System;
using System.ComponentModel.DataAnnotations;

namespace TaskingBoss.Core
{

    public class TaskItem
    {
        public TaskItem()
        {
            CreateDate = DateTime.Now;
            LastUpdatedDate = DateTime.Now;
            Priority = TaskPriority.Normal;
            HasDeadline = false;
        }

        public int Id { get; set; }
        public TaskStatus Status { get; set; }
        public TaskPriority Priority { get; set; }
        public int StoryPoints { get; set; }

        [Required, StringLength(80)]
        public string Title { get; set; }

        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public string ActivityLog { get; set; }
        public bool HasDeadline { get; set; }
        public DateTime Deadline { get; set; }
    }
}
