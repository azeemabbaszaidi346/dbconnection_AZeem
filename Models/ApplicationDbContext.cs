using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace dbconnection_AZeem.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext
            (DbContextOptions <ApplicationDbContext> options):
            base(options) { }
        public DbSet<Location> Location { get; set; }
        public DbSet<Custumer> Customer { get; set; }
    }
}
