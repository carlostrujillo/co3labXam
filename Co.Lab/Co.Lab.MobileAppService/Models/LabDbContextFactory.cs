using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Co.Lab.MobileAppService.Models
{
    public class LabDbContextFactory : IDesignTimeDbContextFactory<LabDbContext>
    {
        public LabDbContext CreateDbContext(string[] args)
        {
            var connection = @"Server=tcp:measuringpoint.database.windows.net,1433;Initial Catalog=CoLab;Persist Security Info=False;User ID={username};Password={password};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            
            var optionsBuilder = new DbContextOptionsBuilder<LabDbContext>();
            optionsBuilder.UseSqlServer(connection);

            return new LabDbContext(optionsBuilder.Options);
        }
    }
}
