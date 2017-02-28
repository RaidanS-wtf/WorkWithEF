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
        public BugViewModel GetOne(int bugId)
        {
            var bug = _context.Bugs.First(oneBug => oneBug.Id == bugId);

            var currentBug = _mapper.Map<Bug, BugViewModel>(bug);
            return currentBug;
        }
        public void CreateBug(BugViewModel createBug)
        {
            var lastBug = _context.Bugs.Last();
            createBug.Id = (lastBug.Id + 1);
            var newBug = _mapper.Map<BugViewModel, Bug>(createBug);
            _context.Bugs.Add(newBug);
            _context.SaveChanges();

        }
        public void EditBug(BugViewModel editBug)
        {
            var foundedBug = _context.Bugs.First(b => b.Id == editBug.Id);
            _mapper.Map(editBug, foundedBug);
            _context.Bugs.Update(foundedBug);
            _context.SaveChanges();
        }
        public void DeleteBug(BugViewModel deleteBug)
        {
            var foundedBug = _context.Bugs.First(b => b.Id == deleteBug.Id);
            _mapper.Map(deleteBug, foundedBug);
            _context.Bugs.Remove(foundedBug);
            _context.SaveChanges();
        }
    }
}
