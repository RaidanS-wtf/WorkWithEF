using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WorkWithEF.Services;
using WorkWithEF.Models;
using WorkWithEF.ViewModels;

namespace WorkWithEF.Controllers
{
    public class BugController : Controller
    {
        private readonly IBugService _bugService;
        public BugController(IBugService bugService)
        {
            _bugService = bugService;
        }
        public IActionResult Index()
        {
            //var bugs = _bugService.GetAll();
            return View();
        }
    }
}
