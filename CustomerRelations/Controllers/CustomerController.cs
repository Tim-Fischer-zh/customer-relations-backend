using Microsoft.AspNetCore.Mvc;
using CustomerRelations.Models;
using CustomerRelations.Services;
using Microsoft.AspNetCore.Authorization;
using CustomerRelations.DTO;

namespace CustomerRelations.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CustomerController : ControllerBase
{
    private readonly CustomerService _customerService;
    public CustomerController(CustomerService customerService)
    {
        _customerService = customerService;
    }
    
    [Authorize]
    [HttpGet]
    public async Task<IActionResult> GetAllAvailableAsync()
    {
        var customers = _customerService.GetAllAvailableCustomersAsync();
        return Ok(customers);
    }

    [Authorize]
    [HttpGet("getall")]
    public async Task<IActionResult> GetAllAsync()
    {
        var customers = _customerService.GetAllCustomersAsync();
        return Ok(customers);
    }

    [Authorize]
    [HttpGet("{id}")]
    public async Task<IActionResult> GetByIdAsync(Customer c)
    {
        var customer = _customerService.GetCustomerAsync(c);
        return Ok(customer);
    }

    [Authorize]
    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CustomerCreateDto dto)
    {
        var customer = new Customer 
        {
            FirmName = dto.FirmName,
            PersonalName = dto.PersonalName,
            PersonalLastName = dto.PersonalLastName,
            Email = dto.Email,
            PhoneNumber = dto.PhoneNumber,
            Address = dto.Address,
            Branch = dto.Branch
            
        };
        
        await _customerService.CreateCustomerAsync(customer);
        return CreatedAtAction(nameof(GetByIdAsync), new { id = customer.Id }, customer);
    }

    [Authorize]
    [HttpDelete("{id}")]
    public async Task<Customer> DeleteCustomerAsync(int id)
    {
        var customer = _customerService.DeleteCustomerAsync(id);
        return await customer;
    }
}