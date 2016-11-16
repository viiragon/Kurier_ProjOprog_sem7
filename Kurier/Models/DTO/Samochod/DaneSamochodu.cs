using Kurier.Models.DTO.Uzytkownik;

namespace Kurier.Models.DTO.Samochod
{
  public class DaneSamochodu
  {
    public DaneKuriera Kurier { get; set; }
    public string NumRejestracyjny { get; set; }
    public string Stan { get; set; }
    public int Id { get; set; }
  }
}