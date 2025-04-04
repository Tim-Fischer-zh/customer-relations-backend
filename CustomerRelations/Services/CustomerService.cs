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

    public async Task<List<Customer>> GetAllAvailableCustomersAsync()
    {
        return await _context.Customers
            .Where(c => c.IsDeleted == false)
            .ToListAsync();
    }
    public async Task<Customer> GetCustomerAsync(Customer customer) => await _context.Customers.FirstOrDefaultAsync(c => c.Id == customer.Id);

    public async Task<Customer> CreateCustomerAsync(Customer customer)
    {
        _context.Customers.Add(customer);
        await _context.SaveChangesAsync();
        return customer;
    }

    public async Task<Customer> DeleteCustomerAsync(int id){
        var existingCustomer = await _context.Customers.FirstOrDefaultAsync(c => c.Id == id);
        if (existingCustomer == null){return null;}
        existingCustomer.IsDeleted = true;
        await _context.SaveChangesAsync();
        return existingCustomer;
    }

}