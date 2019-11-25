using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GloriousProject.Models
{
    public class EntityFrameworkDbContext: DbContext
    {
        public DbSet<Lesson> Lessons { get; set; }
        public EntityFrameworkDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}
