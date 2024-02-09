using Microsoft.EntityFrameworkCore;

namespace dotnetcoresample.Models
{
    public partial class ContosoHRContext:DbContext
    {
        public ContosoHRContext()
        {
        }

        public ContosoHRContext(DbContextOptions<ContosoHRContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Employee> Employees { get; set; }
    }
}
