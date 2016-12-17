using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurier.Interfaces.Presenter
{
    public interface IPKurier
    {
        void wybranoEdytujStatusPaczki(int id);
        void wybranoPokazDateKolejnegoPrzegladu();
        void wybranoPokazListeZlecenKuriera();
        void wybranoPokazSamochodKuriera();
        void wybranoWydajPaczke(Models.DTO.Paczka.DanePaczki paczka);
        void wybranoWylogujKuriera();
        void wybranoPokazSzczegolyPaczkiDlaKuriera(int id);
        void wybranoZalogujKuriera(Models.DTO.Uzytkownik.DaneUzytkownika dane);
        void wybranoZapiszStatusPaczki(Models.DTO.Paczka.Status status, int idPaczki);
    }
}
