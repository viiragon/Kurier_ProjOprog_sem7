using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Kurier.Models.DTO.Samochod;
using Kurier.Views.Menu;
using Kurier.Views.Menu.Samochody;

namespace Kurier.Views.Menu
{
    public class VCentralaSamochody : Interfaces.View.IVCentralaSamochody
    {
        private OknoDodawaniaSamochodu centralaSamochody;
        private OknoEdycjiSamochodu oknoEdycjiSamochodu;
        private OknoListySamochodow oknoListySamochodow;
        private OknoSzczegolowSamochodu oknoSzczegolowSamochodu;
        private OknoWyslaniaZleceniaDoSerwisu oknoWyslaniaZleceniaDoSerwisu;
        private OknoPrzypisaniaKuriera oknoPrzypisaniaKuriera;
        //private OknoPrzypisaniaSamochodu oknoPrzypisaniaSamochodu;
        private Interfaces.Presenter.ICMSamochody samochodyP;

        internal void setOknoPrzypisaniaKuriera(OknoPrzypisaniaKuriera oknoPrzypisaniaKuriera)
        {
            this.oknoPrzypisaniaKuriera = oknoPrzypisaniaKuriera;
        }

        public VCentralaSamochody(Interfaces.Presenter.ICMSamochody samochodyP)
        {
            this.samochodyP = samochodyP;
        }

        public void setOknoWyslaniaZleceniaDoSerwisu(OknoWyslaniaZleceniaDoSerwisu okno)
        {
            this.oknoWyslaniaZleceniaDoSerwisu = okno;
        }

        public void setCentralaSamochody(OknoDodawaniaSamochodu centralaSamochody)
        {
            this.centralaSamochody = centralaSamochody;
        }

        public void setOknoEdycjiSamochodu(OknoEdycjiSamochodu okno)
        {
            this.oknoEdycjiSamochodu = okno;
        }

        public void setOknoListySamochodow(OknoListySamochodow okno)
        {
            this.oknoListySamochodow = okno;
        }

        public void setOknoSzczegolowSamochodu(OknoSzczegolowSamochodu okno)
        {
            this.oknoSzczegolowSamochodu = okno;
        }

        public void setOknoPrzypisaniaSamochodu(/*Samochody.OknoPrzypisaniaSamochodu okno*/)
        {
            //this.oknoPrzypisaniaSamochodu = okno;
        }

        public void wybranoPrzypiszKurieraDoSamochodu(int idSamochodu)
        {
            samochodyP.wybranoPrzypiszKurieraDoSamochodu(idSamochodu);
        }

        public void wybranoDodajSamochod(DaneSamochodu samochod)
        {
            samochodyP.wybranoZapiszNowySamochod(samochod);
        }

        public void wybranoPowiazKurieraZSamochodu(int idSamochodu, int idKuriera)
        {
            samochodyP.wybranoZapiszPowiazanieKurieraZSamochodem(idSamochodu, idKuriera);
        }

        public void wybranoPokazSzczegoly(int idSamochodu)
        {
            samochodyP.wybranoPokazSzczegolySamochodu(idSamochodu);
        }

        public void wybranoUsunSamochod(int idSamochodu)
        {
            samochodyP.wybranoUsunSamochod(idSamochodu);
        }

        public override void aktualizujOknoSzczegolowSamochodu(DaneSamochodu samochod)
        {
           
        }

        public override void wyswietlOknoDodawaniaSamochodu()
        {
            OknoDodawaniaSamochodu.wyswietlOkno(this);
        }

        public void wyswietlOknoEdycjiSamochodu(DaneSamochodu samochod)
        {
            OknoEdycjiSamochodu.wyswietlOkno(this, samochod);
        }

        public override void wyswietlOknoListySamochodow(DaneSamochodu[] lista, string komunikat)
        {
            OknoListySamochodow.wyswietlOkno(this, lista, komunikat);
        }

        public override void wyswietlOknoSzczegolowSamochoduZKomunikatem(DaneSamochodu samochod, string komunikat, Models.DTO.Uzytkownik.DaneKuriera kurier)
        {
            OknoSzczegolowSamochodu.wyswietlOkno(this, samochod, komunikat, kurier);
        }

        public override void wyswietlOknoSzczegolowSamochodu(DaneSamochodu samochod, Models.DTO.Uzytkownik.DaneKuriera kurier)
        {
            OknoSzczegolowSamochodu.wyswietlOkno(this, samochod, null, kurier);
        }

        public override void wyswietlOknoWysylaniaZleceniaDoSerwisu(DaneSamochodu samochod)
        {
            OknoWyslaniaZleceniaDoSerwisu.wyswietlOkno(this, samochod);
        }

        public override void wyswietlOknoPrzypisaniaSamochoduDoKuriera(int idSamochodu, Models.DTO.Uzytkownik.DaneKuriera[] kurierzy)
        {
            OknoPrzypisaniaKuriera.wyswietlOkno(this, idSamochodu, kurierzy);
            //Samochody.OknoPrzypisaniaSamochodu.wyswietlOkno(this, idSamochodu, kurierzy);
        }
    }
}