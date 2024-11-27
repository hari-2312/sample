using Employee_Details.Models;
using Microsoft.EntityFrameworkCore;

namespace Employee_Details.Data
{
    public class AppDbcontext : DbContext
    {
        public AppDbcontext(DbContextOptions<AppDbcontext>options) : base(options) { }
         
        public DbSet<Emp_master> Employee_Register { get; set; }
        
        
        
    }
}
