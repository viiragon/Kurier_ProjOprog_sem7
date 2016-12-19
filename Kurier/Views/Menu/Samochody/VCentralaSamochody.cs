using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Kurier.Models.DTO.Samochod;

namespace Kurier.Views.Menu
{
    public class VCentralaSamochody : Interfaces.View.IVCentralaSamochody
    {
        private OknoDodawaniaSamochodu centralaSamochody;
        private OknoEdycjiSamochodu oknoEdycjiSamochodu;
        private OknoListySamochodow oknoListySamochodow;
        private OknoSzczegolowSamochodu oknoSzczegolowSamochodu;
        private Samochody.OknoPrzypisaniaSamochodu oknoPrzypisaniaSamochodu;
        private Interfaces.Presenter.ICMSamochody samochodyP;

        public VCentralaSamochody(Interfaces.Presenter.ICMSamochody samochodyP)
        {
            this.samochodyP = samochodyP;
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

        public void setOknoPrzypisaniaSamochodu(Samochody.OknoPrzypisaniaSamochodu okno)
        {
            this.oknoPrzypisaniaSamochodu = okno;
        }

        public override void aktualizujOknoSzczegolowSamochodu(DaneSamochodu samochod)
        {
           
        }

        public override void wyswietlOknoDodawaniaSamochodu()
        {
            OknoDodawaniaSamochodu.wyswietlOkno(this);
        }

        public override void wyswietlOknoListySamochodow(DaneSamochodu[] lista)
        {
            OknoListySamochodow.wyswietlOkno(this);
        }

        public override void wyswietlOknoSzczegolowSamochodu(DaneSamochodu samochod)
        {
            OknoSzczegolowSamochodu.wyswietlOkno(this);
        }

        public override void wyswietlOknoWysylaniaZleceniaDoSerwisu(DaneSamochodu samochod)
        {
           
        }


        public override void wyswietlOknoPrzypisaniaSamochoduDoKuriera(int idSamochodu, Models.DTO.Uzytkownik.DaneKuriera[] kurierzy)
        {
            Samochody.OknoPrzypisaniaSamochodu.wyswietlOkno(this, idSamochodu, kurierzy);
        }
    }
}