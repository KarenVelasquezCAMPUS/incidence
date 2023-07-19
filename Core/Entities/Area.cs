using System.ComponentModel.DataAnnotations;

namespace Core.Entities;

public class Area
{
    [Key]
    public int Id_Area { get; set; }
    public string ?Name_Area { get; set; }
    public string ?Description_Area { get; set; }
}