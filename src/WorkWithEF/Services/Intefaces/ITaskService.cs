using System;
using System.Collections.Generic;
using System.Linq;
using WorkWithEF.Models;
using WorkWithEF.ViewModels;

namespace WorkWithEF.Services
{
    public interface ITaskService
    {
        IEnumerable<TaskViewModel> GetAll();
        TaskViewModel GetOne(int taskId);
        void EditTask(TaskViewModel editTask);
    }
}
