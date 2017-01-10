using Kurier.Models.DTO.Uzytkownik;
using System;

namespace Kurier.Models.DTO.Samochod
{
  public class DaneSamochodu
  {
    public string NumRejestracyjny { get; set; }
    public string Marka { get; set; }
    public string Model { get; set; }
    public string Stan { get; set; }
    public DateTime DataKontroli { get; set; }
    public int Id { get; set; }

    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != this.GetType()) return false;
      return Equals((DaneSamochodu)obj);
    }

    protected bool Equals(DaneSamochodu other)
    {
      return string.Equals(NumRejestracyjny, other.NumRejestracyjny) && string.Equals(Marka, other.Marka) && string.Equals(Model, other.Model) && string.Equals(Stan, other.Stan) && DataKontroli.Equals(other.DataKontroli);
    }

    public override int GetHashCode()
    {
      unchecked
      {
        var hashCode = (NumRejestracyjny != null ? NumRejestracyjny.GetHashCode() : 0);
        hashCode = (hashCode * 397) ^ (Marka != null ? Marka.GetHashCode() : 0);
        hashCode = (hashCode * 397) ^ (Model != null ? Model.GetHashCode() : 0);
        hashCode = (hashCode * 397) ^ (Stan != null ? Stan.GetHashCode() : 0);
        hashCode = (hashCode * 397) ^ DataKontroli.GetHashCode();
        return hashCode;
      }
    }
  }
}