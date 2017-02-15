using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkWithEF.Models;
using WorkWithEF.ViewModels;

namespace WorkWithEF.Services
{
    public interface IBugService
    {
        IEnumerable<BugViewModel> GetAll();
    }
}
