using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Contracts;
namespace CustomerRelations.Models;

public class Projects{
    public int Id { get; set; }
    public string? ProjectName { get; set; } 
    public DateOnly? StartDate { get; set; }
    public DateOnly? EndDate { get; set; }

    [ForeignKey("Customer")]
    public int CustomerId { get; set; }

    [ForeignKey("Contract")]
    public int ContractId { get; set; }

    public Customer Customer { get; set; }
    public Contracts Contract { get; set; }
}