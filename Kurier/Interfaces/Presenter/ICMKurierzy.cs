using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kurier.Interfaces.Presenter
{
    public interface ICMKurierzy
    {
        void wybranoDodajKuriera();
        void wybranoEdytujKuriera(int id);
        void wybranoPokazListeKurierow();
        void wybranoPokazSzczegolyKuriera(int id);
        void wybranoZapiszEdycjeKuriera(Models.DTO.Uzytkownik.DaneKuriera kurier);
        void wybranoZapiszNowegoKuriera(Models.DTO.Uzytkownik.DaneKuriera kurier);
    }
}