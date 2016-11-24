using Kurier.Models.DTO.Uzytkownik;

namespace Kurier.Models.DTO.Samochod
{
  public class DaneSamochodu
  {
    public DaneKuriera Kurier { get; set; }
    public string NumRejestracyjny { get; set; }
    public string Stan { get; set; }
    public int Id { get; set; }

    protected bool Equals(DaneSamochodu other)
    {
      return Equals(Kurier, other.Kurier) && string.Equals(NumRejestracyjny, other.NumRejestracyjny) && string.Equals(Stan, other.Stan) && Id == other.Id;
    }

    public override int GetHashCode()
    {
      unchecked
      {
        var hashCode = (Kurier != null ? Kurier.GetHashCode() : 0);
        hashCode = (hashCode*397) ^ (NumRejestracyjny != null ? NumRejestracyjny.GetHashCode() : 0);
        hashCode = (hashCode*397) ^ (Stan != null ? Stan.GetHashCode() : 0);
        hashCode = (hashCode*397) ^ Id;
        return hashCode;
      }
    }
  }
}