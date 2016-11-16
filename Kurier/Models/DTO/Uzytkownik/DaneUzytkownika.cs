namespace Kurier.Models.DTO.Uzytkownik
{
  public class DaneUzytkownika : DaneAuth
  {
    public int Id { get; set; }
    public string Imie { get; set; }
    public string Nazwisko { get; set; }
    public Adres Adres { get; set; }
    public int Telefon { get; set; }
    public int Uprawnienia { get; set; }

  }
}