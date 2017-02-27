using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WorkWithEF.Services;
using WorkWithEF.Models;
using WorkWithEF.ViewModels;

namespace WorkWithEF.Controllers
{
    public class TaskController : Controller
    {
        private readonly ITaskService _taskService;
        public TaskController(ITaskService taskService)
        {
            _taskService = taskService;
        }
        public IActionResult Index()
        {
            var tasks = _taskService.GetAll();
            return View(tasks);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CommitCreate(TaskViewModel createTask)
        {
            if (ModelState.IsValid)
            {
                _taskService.CreateTask(createTask);
                return RedirectToAction("Index");
            }
            return View("Create", createTask);
        }
        public IActionResult Edit(int id)
        {
            var currentTask = _taskService.GetOne(id);
            return View(currentTask);
        }
        [HttpPost]
        public IActionResult CommitEdit(TaskViewModel editTask)
        {
            _taskService.EditTask(editTask);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var currentTask = _taskService.GetOne(id);
            return View(currentTask);
        }
        [HttpPost]
        public IActionResult CommitDelete(TaskViewModel deleteTask)
        {
            _taskService.DeleteTask(deleteTask);
            return RedirectToAction("Index");
        }
    }
}
