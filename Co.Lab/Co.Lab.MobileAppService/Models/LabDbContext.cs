using Co.Lab.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Co.Lab.MobileAppService.Models
{
    public class LabDbContext : DbContext
    {
        public LabDbContext(DbContextOptions<LabDbContext> options)
            : base(options)
        { }

        public DbSet<Person> Persons { get; set; }
        
    }
}
