using System;
using Kurier.Models.DTO.Uzytkownik;

namespace Kurier.Models.DTO.Paczka
{
  public class Status
  {
    public int Id { get; set; }
    public int KodStatusu { get; set; }
    public DateTime Czas { get; set; }
    public DaneKuriera Kurier { get; set; }

    protected bool Equals(Status other)
    {
      return Id == other.Id && KodStatusu == other.KodStatusu && Czas.Equals(other.Czas) && Equals(Kurier, other.Kurier);
    }

    public override int GetHashCode()
    {
      unchecked
      {
        var hashCode = Id;
        hashCode = (hashCode*397) ^ KodStatusu;
        hashCode = (hashCode*397) ^ Czas.GetHashCode();
        hashCode = (hashCode*397) ^ (Kurier != null ? Kurier.GetHashCode() : 0);
        return hashCode;
      }
    }
  }
}