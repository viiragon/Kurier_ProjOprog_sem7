using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kurier.Interfaces.Presenter
{
    public abstract class ICMStatystyka
    {
        public abstract void wybranoWylogujZCentrali();
        public abstract void wybranoZalogujDoCentrali(Models.DTO.Uzytkownik.DaneAuthUzytkownika dane);
    }
}