using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkWithEF.Models
{
    public class DataSeeder
    {
        private readonly DataContext _context;
        public DataSeeder(DataContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (!_context.Tasks.Any())
            {
                _context.Tasks.AddRange(
                    new Task { Id = 1, Title = "NumverOne", Description = "First task", Performer="employee1" },
                    new Task { Id = 2, Title = "NumverTwo", Description = "Second task", Performer = "employee1" },
                    new Task { Id = 3, Title = "NumverThree", Description = "Third task", Performer = "employee2" },
                    new Task { Id = 4, Title = "NumverFour", Description = "fourth task", Performer = "employee2" }
                );

                _context.SaveChanges();
            }

            if (!_context.Bugs.Any())
            {
                _context.Bugs.AddRange(
                    new Bug { Id = 1, Name = "BugNumberOne", Description = "First Bug", Author = "employee7" },
                    new Bug { Id = 2, Name = "BugNumberTwo", Description = "Second Bug", Author = "employee7" },
                    new Bug { Id = 3, Name = "BugNumberThree", Description = "Third Bug", Author = "employee9" },
                    new Bug { Id = 4, Name = "BugNumberFour", Description = "fourth Bug", Author = "employee9" }
                );

                _context.SaveChanges();
            }
        }
    }
}
