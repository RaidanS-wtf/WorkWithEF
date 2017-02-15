using System;
using System.Collections.Generic;
using System.Linq;
using WorkWithEF.Models;
using WorkWithEF.ViewModels;
using AutoMapper;

namespace WorkWithEF.Services
{
    public class BugService : IBugService
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public BugService(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IEnumerable<BugViewModel> GetAll()
        {
            var bugs = _mapper.Map<IEnumerable<Bug>, IEnumerable<BugViewModel>>(_context.Bugs.ToList());

            return bugs;
        }
    }
}
