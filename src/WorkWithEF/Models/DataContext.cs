using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkWithEF.Models
{
    public class DataContext : DbContext
    {
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Bug> Bugs { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlite("Filename=./tfs.db");
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Blogging;Trusted_Connection=True;"); //
            // var connString = "Data source=;Initial catalog=races;user=;password=;MultipleActiveResultSets=true;";
            // optionsBuilder.UseSqlServer(connString);

            base.OnConfiguring(optionsBuilder);
        }
    }
}
