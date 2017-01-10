using System.Collections.Generic;
using Kurier.Models.DTO.Paczka;
using Kurier.Models.DTO.Uzytkownik;

namespace Kurier.Models.DTO.Statystyka
{
  public class ObciazenieKurierow
  {
    public List<StatystykaKuriera> ListaKurierow { get; set; } 

    public class StatystykaKuriera
    {
      public DaneKuriera Kurier { get; set; }
      public int IloscPaczek { get; set; }
      public List<DanePaczki> PrzypisanePaczki { get; set; }
    }

    
  }

}