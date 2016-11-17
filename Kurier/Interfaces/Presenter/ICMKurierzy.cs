using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kurier.Interfaces.Presenter
{
    public abstract class ICMKurierzy
    {
        public abstract void wybranoDodajKuriera();
        public abstract void wybranoEdytujKuriera(int id);
        public abstract void wybranoPokazListeKurierow();
        public abstract void wybranoZapiszEdycjeKuriera(Models.DTO.Uzytkownik.DaneKuriera kurier);
        public abstract void wybranoZapiszNowegoKuriera(Models.DTO.Uzytkownik.DaneKuriera kurier);
    }
}