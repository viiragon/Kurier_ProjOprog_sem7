using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kurier.Interfaces.Presenter
{
    public abstract class ICMSamochody
    {
        public abstract void wybranoAktualizujSzczegolySamochodu(int id);
        public abstract void wybranoDodajSamochod();
        public abstract void wybranoOtworzFormularzZleceniaDoSerwisu(int id);
        public abstract void wybranoPokazListeSamochodow();
        public abstract void wybranoPokazSzczegolySamochodu(int id);
        public abstract void wybranoPrzypiszKurieraDoSamochodu(int idSamochodu);
        public abstract void wybranoUsunSamochod(int id);
        public abstract void wybranoWyslijZlecenieDoSerwisu();
        public abstract void wybranoZapiszNowySamochod(Models.DTO.Samochod.DaneSamochodu dane);
        public abstract void wybranoZapiszPowiazanieKurieraZSamochodem(int idKuriera);
    }
}