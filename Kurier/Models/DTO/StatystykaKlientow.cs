namespace Kurier.Models.DTO
{
    public class StatystykaKlientow
    {
      public DaneKlienta DaneKlienta { get; set; }
      public DanePaczki[] DaneWyslanychPaczek { get; set; }
      public DanePaczki[] DaneOdebranychPaczek { get; set; }
    }
}