using Microsoft.EntityFrameworkCore;
using CustomerRelations.Models;

namespace CustomerRelations.Data;

public class CustomerRelationsContext : DbContext
{
    public CustomerRelationsContext(DbContextOptions<CustomerRelationsContext> options) : base (options)
    {
        
    }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Invoices> Invoices { get; set; }
    public DbSet<Projects> Projects { get; set; }
    public DbSet<Contracts> Contracts { get; set; }
}