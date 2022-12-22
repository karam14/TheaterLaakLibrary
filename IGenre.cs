using System.ComponentModel.DataAnnotations;

namespace TheaterLaakLibrary;
public interface IGenre
{
    [Key]
    public int Id { get; set; }
    public string Naam { get; set; }
}
