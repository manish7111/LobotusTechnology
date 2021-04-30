using Microsoft.EntityFrameworkCore;
using ModelLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryLayer.UserContext
{
    public class ProblemDBContext : DbContext
    {
        public ProblemDBContext(DbContextOptions<ProblemDBContext> options) : base(options)
        {

        }
        public DbSet<City> City { get; set; }
        public DbSet<Zone> Zone { get; set; }
        public DbSet<Rate> Rate { get; set; }
        public DbSet<Direction> Direction { get; set; }
    }
}
