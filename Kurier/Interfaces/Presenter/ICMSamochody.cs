using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kurier.Interfaces.Presenter
{
    public interface ICMSamochody
    {
        void wybranoAktualizujSzczegolySamochodu(int id);
        void wybranoDodajSamochod();
        void wybranoOtworzFormularzZleceniaDoSerwisu(int id);
        void wybranoPokazListeSamochodow();
        void wybranoPokazSzczegolySamochodu(int id);
        void wybranoPrzypiszKurieraDoSamochodu(int idSamochodu);
        void wybranoUsunSamochod(int id);
        void wybranoWyslijZlecenieDoSerwisu(Models.DTO.Samochod.DaneSamochodu dane);
        void wybranoZapiszNowySamochod(Models.DTO.Samochod.DaneSamochodu dane);
        void wybranoZapiszPowiazanieKurieraZSamochodem(int idSamochodu, int idKuriera);
    }
}