using Microsoft.AspNetCore.Mvc;
using CustomerRelations.Models;
using CustomerRelations.Services;
using Microsoft.AspNetCore.Authorization;

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
    public async Task<IActionResult> Create([FromBody] Customer customer)
    {
        var newCustomer = await _customerService.CreateCustomerAsync(customer);
        return CreatedAtAction(nameof(GetByIdAsync), new { id = newCustomer.Id }, newCustomer);
    }
}