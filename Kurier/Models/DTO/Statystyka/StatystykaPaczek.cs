using Kurier.Models.DTO.Paczka;

namespace Kurier.Models.DTO.Statystyka
{
    public class StatystykaPaczek
    {
      public int LiczbaNadanychPaczek { get; set; }
      public int  LiczbaDostarczonychPaczek { get; set; }
      public int  SredniaLiczbaPaczekNaKuriera { get; set; }
    }
}