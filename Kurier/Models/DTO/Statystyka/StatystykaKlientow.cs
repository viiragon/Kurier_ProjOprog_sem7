using System.Collections.Generic;
using Kurier.Models.DTO.Paczka;
using Kurier.Models.DTO.Uzytkownik;

namespace Kurier.Models.DTO.Statystyka
{
  public class StatystykaKlientow
  {
    public List<DaneStatystykiKlienta> StatystykiKlienta { get; set; }

    public class DaneStatystykiKlienta
    {
      public DaneKlienta DaneKlienta { get; set; }
      public int LiczbaPaczek { get; set; }
    }
  }
}