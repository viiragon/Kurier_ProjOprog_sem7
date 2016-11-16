using Kurier.Models.DTO.Paczka;
using Kurier.Models.DTO.Uzytkownik;

namespace Kurier.Models.DTO.Statystyka
{
    public class StatystykaKlientow
    {
      public DaneKlienta DaneKlienta { get; set; }
      public DanePaczki[] DaneWyslanychPaczek { get; set; }
      public DanePaczki[] DaneOdebranychPaczek { get; set; }
    }
}