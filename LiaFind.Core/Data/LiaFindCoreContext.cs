using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LiaFind.Core.Models;

namespace LiaFind.Core.Data
{
    public class LiaDbContext : DbContext
    {
        public LiaDbContext (DbContextOptions<LiaDbContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Student { get; set; }
    }
}
