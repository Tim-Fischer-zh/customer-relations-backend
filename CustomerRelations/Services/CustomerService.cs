using CustomerRelations.Data;
using CustomerRelations.Models;
using Microsoft.EntityFrameworkCore;

namespace CustomerRelations.Services;

public class CustomerService{

    private readonly CustomerRelationsContext _context;
    public CustomerService(CustomerRelationsContext context)
    {
        _context = context;
    }

    public async Task<List<Customer>> GetAllCustomersAsync() => await _context.Customers.ToListAsync();
    public async Task<Customer> GetCustomerAsync(Customer customer) => await _context.Customers.FirstOrDefaultAsync(c => c.Id == customer.Id);
}