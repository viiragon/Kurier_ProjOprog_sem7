using System;
using System.Collections.Generic;
using Kurier.Models.DTO;
using Kurier.Models.DTO.Samochod;

namespace Kurier.Interfaces.Model
{
  public interface IMSamochody
  {

    void DodajSamochod(DaneSamochodu samochod);

    List<DaneSamochodu> PobierzListeSamochodow();

    DaneSamochodu PobierzSamochod(int id);

    void PowiazKurieraISamochod(int idSamochodu, int idKuriera);

    void UsunSamochod(int id);

    bool WalidujDaneSamochodu(DaneSamochodu samochod);

    List<DaneSamochodu> PobierzListeSamochodowZDataKontroli(DateTime od, DateTime @do);

    void ZmienDaneSamochodu(DaneSamochodu daneSamochodu);
  }
}