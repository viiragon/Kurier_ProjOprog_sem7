using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kurier.Interfaces.Presenter
{
    public interface ICMPaczki
    {
        void wybranoEdytujStatusPaczki(int id);
        void wybranoPokazListePaczek();
        void wybranoPokazSzczegolyPaczki(int id);
        void wybranoPokazSzczegolyKurieraDlaPaczki(int id);
        void wybranoPrzypiszKurieraDoPaczki(int idPaczki);
        void wybranoZapiszPowiazanieKurieraZPaczka(int idPaczki, int idKuriera);
        void wybranoZapiszStatusPaczkiDlaCentrali(Models.DTO.Paczka.Status status, int idPaczki);
    }
}