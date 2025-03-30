namespace CustomerRelations.Models;

public class Contracts{

    public Contracts() {}

    public int Id { get; set; }
    public string? FileAddress { get; set; }
    public DateOnly ContractStart { get; set; }
    public DateOnly ContractEnd { get; set; }
    public bool Signature { get; set; }

    public int CustomerId { get; set; }
}