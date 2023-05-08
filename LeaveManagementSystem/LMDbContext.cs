using LeaveManagementSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagementSystem
{
    public class LMDbContext:DbContext
    {

        public LMDbContext(DbContextOptions options): base(options) 
        { 
                
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }

        internal Task<string?> ToListAsync()
        {
            throw new NotImplementedException();
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        public DbSet<Designation> Designations { get; set;}

        public  DbSet<Leave> Leaves { get; set; }

        public DbSet<LeaveApproved> LeaveApproved { get; set;}

    }
}
