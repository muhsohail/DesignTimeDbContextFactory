using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace DesignTimeDbContextFactory
{
    public class StudentContextFactory : IDesignTimeDbContextFactory<StudentContext>
    {
        public StudentContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<StudentContext>();
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=SampleDesignTimeDbContext;Trusted_Connection=True;MultipleActiveResultSets=true");

            return new StudentContext(optionsBuilder.Options);
        }
    }
}
