using System.ComponentModel.DataAnnotations;

namespace Core.Entities;

public class State
{
    [Key]
    public int Id_State { get; set; }
    public string ?Description_State { get; set; }
}