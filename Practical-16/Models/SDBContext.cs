using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practical16.Models
{
    public class SDBContext : IdentityDbContext
    {
        public SDBContext(DbContextOptions<SDBContext> options) : base(options)
        {

        }

        
        public DbSet<Student> Students { get; set; }
    }
}
