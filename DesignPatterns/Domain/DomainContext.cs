using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;

namespace DesignPatterns
{
    public class DomainContext : DbContext
    {
        public DomainContext()
        {

        }
       
        public DbSet<Departments> Departments { get; set; }
        public DbSet<Employees> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS; Database=EFCoreDemo;Trusted_Connection=True;MultipleActiveResultSets=true");
            // use .\SQLEXPRESS if you got instance failure error while running update-database command.

            optionsBuilder.LogTo(Console.WriteLine);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // configure one to many relationship.
            modelBuilder.Entity<Departments>().
                HasMany(d => d.Employees)
                .WithOne(s => s.Department);

            modelBuilder.Entity<Employees>(b =>{
                b.HasKey(e => e.EmployeeId);
                b.Property(e => e.EmployeeId).ValueGeneratedOnAdd();
                b.HasOne(s => s.Department).WithMany(d => d.Employees).IsRequired();                
            });
                
        }

        
    }
}
