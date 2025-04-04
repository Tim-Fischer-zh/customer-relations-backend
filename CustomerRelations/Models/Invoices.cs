
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Contracts;

namespace CustomerRelations.Models;

public class Invoices{

    public Invoices() {}

    public int Id { get; set; }
    public string? FileAddress { get; set; }
    public DateOnly SendDate { get; set; }
    public DateOnly DueDate { get; set; }
    public float Amount { get; set; }

    [ForeignKey("Customer")]
    public int CustomerId { get; set; }
    public Customer Customer { get; set; }
}