
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Contracts;

namespace CustomerRelations.Models;

public class Customer{

    [Key]
    public int Id { get; set; }
    public string? FirmName { get; set; }
    public string? PersonalName { get; set; }
    public string? PersonalLastName { get; set; }
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Address { get; set; }
    public string? Branch { get; set; }


   // Navigation Properties
        public ICollection<Invoices> Invoices { get; set; }
        public ICollection<Projects> Projects { get; set; }
        public ICollection<Contracts> Contracts { get; set; }
}