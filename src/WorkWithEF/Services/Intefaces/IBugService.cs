using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkWithEF.Models;

namespace WorkWithEF.Services
{
    public interface IBugService
    {
        IEnumerable<Bug> GetAll();
    }
}
