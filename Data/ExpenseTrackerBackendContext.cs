using Microsoft.EntityFrameworkCore;
using ExpenseTrackerBackend.Models;

namespace ExpenseTrackerBackend.Data
{
    public class ExpenseTrackerBackendContext : DbContext
    {
        public ExpenseTrackerBackendContext (DbContextOptions<ExpenseTrackerBackendContext> options)
        : base (options) {}

        public DbSet <Category> Category { get; set; }
        public DbSet <Payment> Payment { get; set; }
    } 
}

