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
        private readonly IMapper _mapper;

        public TaskService(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IEnumerable<TaskViewModel> GetAll()
        {
            var tasks = _mapper.Map<IEnumerable<Task>, IEnumerable<TaskViewModel>>(_context.Tasks.ToList());

            return tasks;
        }
        public TaskViewModel GetOne(int taskId)
        {
            var task = _context.Tasks.First(oneTask => oneTask.Id == taskId);

            var currentTask = _mapper.Map<Task, TaskViewModel>(task);
            return currentTask;
        }
        public void EditTask(TaskViewModel editTask)
        {
            var foundedTask = _context.Tasks.First(t => t.Id == editTask.Id);
            _mapper.Map(editTask, foundedTask);
            _context.Tasks.Update(foundedTask);
            _context.SaveChanges();
        }
    }
}
