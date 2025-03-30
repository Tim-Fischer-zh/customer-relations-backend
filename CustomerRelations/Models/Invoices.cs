namespace CustomerRelations.Models;

public class Invoices{

    public Invoices() {}

    public int Id { get; set; }
    public string? FileAddress { get; set; }
    public DateOnly SendDate { get; set; }
    public DateOnly DueDate { get; set; }
    public float Amount { get; set; }
    public int CustomerId { get; set; }
}