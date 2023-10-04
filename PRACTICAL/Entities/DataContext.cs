using System;
using Microsoft.EntityFrameworkCore;


namespace PRACTICAL.Entities
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<Department> Department { get; set; }
    }
}
