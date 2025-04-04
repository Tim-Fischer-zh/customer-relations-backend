namespace CustomerRelations.DTO;
public class CustomerCreateDto
{
    public string? FirmName { get; set; }
    public string? PersonalName { get; set; }
    public string? PersonalLastName { get; set; }
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Address { get; set; }
    public string? Branch { get; set; }
    public bool? Isdeleted { get; set; }
}