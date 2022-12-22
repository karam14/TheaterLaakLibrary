using System.ComponentModel.DataAnnotations;
namespace TheaterLaakLibrary;
public interface IKaart
{
    [Key]
    public int Id { get; set; }
    public string Waarheidsmerk { get; set; }
}
