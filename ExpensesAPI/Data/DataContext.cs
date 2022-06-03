using Microsoft.EntityFrameworkCore;

namespace ExpensesAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){}

        public DbSet<Expense> Expenses { get; set; }

        public DbSet<ExpenseType> ExpenseTypes { get; set; }

    }
}
