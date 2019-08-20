using DateingBackEnd.Models;
using Microsoft.EntityFrameworkCore;

namespace DateingBackEnd.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options)
        {

        }

        public DbSet<Value> Values { get; set; }
    }
}
