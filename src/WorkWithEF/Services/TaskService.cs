using System;
using System.Collections.Generic;
using System.Linq;
using WorkWithEF.Models;
using WorkWithEF.ViewModels;
using AutoMapper;

namespace WorkWithEF.Services
{
    public class TaskService : ITaskService
    {
        private readonly DataContext _context;

        public TaskService(DataContext context)
        {
            _context = context;
        }

        public IEnumerable<Task> GetAll()
        {
            return _context.Tasks;
        }
    }
}
