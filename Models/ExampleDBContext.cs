using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeSample.Models
{
    public class ExampleDBContext: DbContext
    {
        public ExampleDBContext()
        {

        }

        public ExampleDBContext(DbContextOptions<ExampleDBContext> options):base (options)
        {

        }

        public virtual DbSet<Employee> Employee { get; set; }

    }
}
