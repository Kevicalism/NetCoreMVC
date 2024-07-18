using Microsoft.EntityFrameworkCore;
using SpendSmart.Models;

namespace Spending_Application_Online.Models
{
    public class SpendSmartDBContext :DbContext
    {
        public DbSet<Expense> Expenses { get; set; }

        public SpendSmartDBContext(DbContextOptions<SpendSmartDBContext> options)
            : base(options)
        {

        }
    }
}
