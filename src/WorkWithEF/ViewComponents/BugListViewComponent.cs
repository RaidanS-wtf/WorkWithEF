using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace WorkWithEF.ViewComponents
{
    public class BugListViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var data = GetSampleData();
            return View(data);
        }

        private List<string> GetSampleData()
        {
            List<string> data = new List<string>();
            data.Add("One");
            data.Add("Two");
            data.Add("Three");
            return data;
        }
    }
}
