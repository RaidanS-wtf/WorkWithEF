using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WorkWithEF.Services;

namespace WorkWithEF.Controllers
{
    public class EditTaskController : Controller
    {
        private readonly ITaskService _taskService;
        public EditTaskController(ITaskService taskService)
        {
            _taskService = taskService;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Edit(int taskId)
        {
            var task = _taskService.GetOne(taskId);
            return View(task);
        }
    }
}
