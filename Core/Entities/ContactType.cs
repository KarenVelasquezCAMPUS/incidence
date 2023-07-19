using System.ComponentModel.DataAnnotations;

namespace Core.Entities;

public class ContactType
{
    [Key]
    public int Id_ContactType { get; set; }
    public string ?Name_ContactType { get; set; }
    public string ?Description_ContactType { get; set; }
}