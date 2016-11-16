using System.Collections.Generic;
using Kurier.Models.DTO;
using Kurier.Models.DTO.Paczka;
using Kurier.Models.DTO.Samochod;
using Kurier.Models.DTO.Uzytkownik;

namespace Kurier.Interfaces.Model
{
  public interface IMKurierzy
  {
    void DodajKuriera(DaneKuriera kurier);
    DaneKuriera PobierzKuriera(int id);
    List<DaneKuriera> PobierzListeKurierow();
    List<DanePaczki> PobierzListePaczekKuriera(int idKuriera);
    DaneSamochodu PobierzSamochodKuriera(int id);
    bool WalidujDaneKuriera(DaneKuriera kurier);
  }
}