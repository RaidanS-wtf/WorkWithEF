using System;
using System.Collections.Generic;
using System.Linq;
using WorkWithEF.Models;

namespace WorkWithEF.Services
{
    public class BugService : IBugService
    {
        private readonly DataContext _context;

        public BugService(DataContext context)
        {
            _context = context;
        }

        public IEnumerable<Bug> GetAll()
        {
            return _context.Bugs.ToList();
        }
    }
}
