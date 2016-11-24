namespace Kurier.Models.DTO.Uzytkownik
{
  public class DaneKuriera : DaneUzytkownika
  {
    public int NumerPracowanika { get; set; }

    protected bool Equals(DaneKuriera other)
    {
      return base.Equals(other) && NumerPracowanika == other.NumerPracowanika;
    }

    public override int GetHashCode()
    {
      return NumerPracowanika;
    }
  }

}