using Microsoft.EntityFrameworkCore;
using MultiplexCoreFiveCodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiplexCoreFiveCodeFirst.Data
{
    public class MultiplexDbContext : DbContext 
    {
        public MultiplexDbContext(DbContextOptions<MultiplexDbContext> options) : base(options)
        {

        }

        public DbSet<Country> Country { get; set; }
        public DbSet<User> User { get; set; }
    }
}
