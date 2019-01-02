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
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connection = @"Server=tcp:measuringpoint.database.windows.net,1433;Initial Catalog=CoLab;Persist Security Info=False;User ID=carlos;Password=All3sIstGut;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";


            optionsBuilder.UseSqlServer(connection);
        }

        public DbSet<Person> Persons { get; set; }
        
    }
}
