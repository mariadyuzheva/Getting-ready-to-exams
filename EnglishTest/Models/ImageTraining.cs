﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EnglishTest.Models
{
    public class ImageTraining : ITraning
    {
        public ImageTraining(TaskService db, ICondition condition) : base(db, condition)
        {
        }

        async public override Task CreateTasks()
        {
            var tasksId = await db.GetTasksId("images");
            foreach (var taskId in tasksId)
            {
                Tasks[taskId] = "images";
            }
            TasksId = new List<string>(Tasks.Keys);
        }
    }
}