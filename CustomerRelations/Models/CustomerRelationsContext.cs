using Microsoft.EntityFrameworkCore;


namespace CustomerRelations.Models;

public class CustomerRelationsContext : DbContext
{
    public CustomerRelationsContext(DbContextOptions<CustomerRelationsContext> options) : base (options)
    {
        
    }
    public DbSet<CustomerRelations> Customers { get; set; }
    public DbSet<Invoices> Invoices { get; set; }
    public DbSet<Projects> Projects { get; set; }
    public DbSet<Contracts> Contracts { get; set; }
}