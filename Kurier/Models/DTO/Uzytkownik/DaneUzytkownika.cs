namespace Kurier.Models.DTO.Uzytkownik
{
  public class DaneUzytkownika : DaneAuth
  {
    public string Imie { get; set; }
    public string Nazwisko { get; set; }
    public Adres Adres { get; set; }
    public int Telefon { get; set; }
    public int Uprawnienia { get; set; }


    protected bool Equals(DaneUzytkownika other)
    {
      return string.Equals(Imie, other.Imie) && string.Equals(Nazwisko, other.Nazwisko) && Equals(Adres, other.Adres) && Telefon == other.Telefon && Uprawnienia == other.Uprawnienia;
    }

    public override int GetHashCode()
    {
      unchecked
      {
        var hashCode = UserId;
        hashCode = (hashCode*397) ^ (Imie != null ? Imie.GetHashCode() : 0);
        hashCode = (hashCode*397) ^ (Nazwisko != null ? Nazwisko.GetHashCode() : 0);
        hashCode = (hashCode*397) ^ (Adres != null ? Adres.GetHashCode() : 0);
        hashCode = (hashCode*397) ^ Telefon;
        hashCode = (hashCode*397) ^ Uprawnienia;
        return hashCode;
      }
    }
  }
}