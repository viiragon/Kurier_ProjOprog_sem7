using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Kurier.Interfaces.Presenter;
using Kurier.Models.DTO.Samochod;
using Kurier.Models.DataAccess;
using Kurier.Models.DTO.Uzytkownik;

namespace Kurier.Presenters.CentralaManager.SamochodyCM
{
    public class SamochodyPrezenter : ICMSamochody
    {
        private Interfaces.View.IVCentralaSamochody samochody;
        private SamochodyModel samochodyModel;
        private KurierzyModel kurierzyModel;
        public SamochodyPrezenter()
        {
            samochody = Interfaces.View.IVCentralaSamochody.createInstance(this);
            samochodyModel = new SamochodyModel();
            kurierzyModel = new KurierzyModel();
        }

        public void wybranoAktualizujSzczegolySamochodu(int id)
        {
            DaneSamochodu samochod = samochodyModel.PobierzSamochod(id);
            samochody.aktualizujOknoSzczegolowSamochodu(samochod);
        }

        public void wybranoDodajSamochod()
        {
            samochody.wyswietlOknoDodawaniaSamochodu();
        }

        public void wybranoOtworzFormularzZleceniaDoSerwisu(int id)
        {
            DaneSamochodu samochod = samochodyModel.PobierzSamochod(id);
            samochody.wyswietlOknoWysylaniaZleceniaDoSerwisu(samochod);
        }

        public void wybranoPokazListeSamochodow()
        {
            DaneSamochodu[] listaSamochodow = samochodyModel.PobierzListeSamochodow().ToArray();
            samochody.wyswietlOknoListySamochodow(listaSamochodow);
        }

        public void wybranoPokazSzczegolySamochodu(int id)
        {
            DaneSamochodu samochod = samochodyModel.PobierzSamochod(id);
            samochody.wyswietlOknoSzczegolowSamochodu(samochod);
        }

        public void wybranoPrzypiszKurieraDoSamochodu(int idSamochodu)
        {
            throw new NotImplementedException();
        }

        public void wybranoUsunSamochod(int id)
        {
            samochodyModel.UsunSamochod(id);
            wybranoPokazListeSamochodow();
        }

        public void wybranoWyslijZlecenieDoSerwisu()
        {
            throw new NotImplementedException();
        }

        public void wybranoZapiszNowySamochod(DaneSamochodu dane)
        {
            bool czyPoprawneDane = samochodyModel.WalidujDaneSamochodu(dane);
            if (czyPoprawneDane)
            {
                samochodyModel.DodajSamochod(dane);
                //komunikat o dodaniu
            }
            wybranoPokazListeSamochodow();
        }

        public void wybranoZapiszPowiazanieKurieraZSamochodem(int idSamochodu, int idKuriera)
        {
            DaneSamochodu dSamochod = samochodyModel.PobierzSamochod(idSamochodu);
            DaneKuriera dKuriera = kurierzyModel.PobierzKuriera(idKuriera);

            bool poprawneDaneSamochod = samochodyModel.WalidujDaneSamochodu(dSamochod);
            bool poprawneDaneKurier = kurierzyModel.WalidujDaneKuriera(dKuriera);
            if (poprawneDaneSamochod && poprawneDaneKurier)
            {
                samochodyModel.PowiazKurieraISamochod(idSamochodu, idKuriera);
                //Dodac komunikat
            }
            //throw new NotImplementedException();    
        }
    }
}