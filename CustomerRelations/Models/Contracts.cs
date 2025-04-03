using System.ComponentModel.DataAnnotations.Schema;

namespace CustomerRelations.Models;

public class Contracts{

    public Contracts() {}

    public int Id { get; set; }
    public string? FileAddress { get; set; }
    public DateOnly ContractStart { get; set; }
    public DateOnly ContractEnd { get; set; }
    public bool Signature { get; set; }

    [ForeignKey("Customer")]
    public int CustomerId { get; set; }

    // Navigation Property
    public CustomerRelations Customer { get; set; }

    // Optionale Navigation für Projekte
    public ICollection<Projects> Projects { get; set; }
}