using Microsoft.EntityFrameworkCore;

namespace Expense_Tracker.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions options):base(options)
        {}
        //during frun time the  these 2  classes will be converted into table  whihc  will only  happen if both the classes were
        //present in the framework 
        //during migration the table will be named as provided here
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
