

namespace Kurier.Models.DTO
{
  public class Adres
  {
    public string Miasto { get; set; }
    public string KodPocztowy { get; set; }
    public string Ulica { get; set; }
    public string NumerMieszkania { get; set; }

    protected bool Equals(Adres other)
    {
      return string.Equals(Miasto, other.Miasto) && string.Equals(KodPocztowy, other.KodPocztowy) && string.Equals(Ulica, other.Ulica) && string.Equals(NumerMieszkania, other.NumerMieszkania);
    }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((Adres) obj);
    }

    public override int GetHashCode()
    {
      unchecked
      {
        var hashCode = (Miasto != null ? Miasto.GetHashCode() : 0);
        hashCode = (hashCode*397) ^ (KodPocztowy != null ? KodPocztowy.GetHashCode() : 0);
        hashCode = (hashCode*397) ^ (Ulica != null ? Ulica.GetHashCode() : 0);
        hashCode = (hashCode*397) ^ (NumerMieszkania != null ? NumerMieszkania.GetHashCode() : 0);
        return hashCode;
      }
    }

    public string getProperAddressString()
    {
        return this.Ulica + " " + this.NumerMieszkania + ", " + this.Miasto + " " + this.KodPocztowy;
    }
  }
}