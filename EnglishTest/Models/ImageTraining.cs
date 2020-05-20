﻿using System.Collections.Generic;

namespace EnglishTest.Models
{
    public class ImageTraining : Training
    {
        public ImageTraining(string level, int tasksNumber, ITrainingEndCondition condition) 
            : base(level, tasksNumber, condition) {}

        public override void CreateTasks(TaskService db)
        {
            AddTasks(db, "images", ImageAnswer.MaxCount);
            TasksIds = new List<string>(Tasks.Keys);
            Results = new Results(Tasks, MaxCount);
            isFinish = Condition.IsFinish(Results);
        }
    }
}
