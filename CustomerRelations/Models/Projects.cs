namespace CustomerRelations.Models;

public class Projects{
    public Projects() {}
    public int Id { get; set; }
    public string? ProjectName { get; set; } 
    public DateOnly? StartDate { get; set; }
    public DateOnly? EndDate { get; set; }
    public int CustomerId { get; set; }
    public int ContractId { get; set;}
}