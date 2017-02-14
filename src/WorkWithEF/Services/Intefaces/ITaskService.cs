using System;
using System.Collections.Generic;
using System.Linq;
using WorkWithEF.Models;

namespace WorkWithEF.Services
{
    public interface ITaskService
    {
        IEnumerable<Task> GetAll();
    }
}
