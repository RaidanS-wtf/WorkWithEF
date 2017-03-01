using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WorkWithEF.Services;
using WorkWithEF.ViewModels;

namespace WorkWithEF.ViewComponents
{
    public class BugListViewComponent : ViewComponent
    {
        private readonly IBugService _bugService;
        public BugListViewComponent(IBugService bugService)
        {
            _bugService = bugService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var bugs = await GetAllBugsAsync();
            return View(bugs);
        }
        private Task<IEnumerable<BugViewModel>> GetAllBugsAsync()
        {
            return _bugService.GetAllAsync();
        }
    }
}
