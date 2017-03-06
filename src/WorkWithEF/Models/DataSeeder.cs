using System;
using System.Collections.Generic;
using System.Linq;

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
                    new Task { Name = "NumverOne", Description = "First task", Performer="employee1" },
                    new Task { Name = "NumverTwo", Description = "Second task", Performer = "employee1" },
                    new Task { Name = "NumverThree", Description = "Third task", Performer = "employee2" },
                    new Task { Name = "NumverFour", Description = "fourth task", Performer = "employee2" }
                );

                _context.SaveChanges();
            }

            if (!_context.Bugs.Any())
            {
                _context.Bugs.AddRange(
                    new Bug { Name = "BugNumberOne", Description = "First Bug", Author = "employee7" },
                    new Bug { Name = "BugNumberTwo", Description = "Second Bug", Author = "employee7" },
                    new Bug { Name = "BugNumberThree", Description = "Third Bug", Author = "employee9" },
                    new Bug { Name = "BugNumberFour", Description = "fourth Bug", Author = "employee9" }
                );

                _context.SaveChanges();
            }

            if (!_context.Statuses.Any())
            {
                _context.Statuses.AddRange(
                    new Status { StatusTitle = "In work" },
                    new Status { StatusTitle = "Pending" },
                    new Status { StatusTitle = "Ready" },
                    new Status { StatusTitle = "Done" }
                );

                _context.SaveChanges();
            }
        }
    }
}
