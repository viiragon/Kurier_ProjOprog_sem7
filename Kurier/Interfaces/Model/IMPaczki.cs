using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kurier.Models.DTO;
using Kurier.Models.DTO.Paczka;

namespace Kurier.Interfaces.Model
{
  public interface IMPaczki
  {
    void DodajPaczke(DanePaczki paczka);

    List<DanePaczki> PobierzListePaczek();
    
    DanePaczki PobierzPaczke(int id);

    void PowiazKurieraIPaczke(int idPaczki, int idKuriera);
    
    bool WalidujDanePaczki(DanePaczki paczka);
    
    void ZmienStatusPaczki(Status status,int idPaczki);
  }
}
