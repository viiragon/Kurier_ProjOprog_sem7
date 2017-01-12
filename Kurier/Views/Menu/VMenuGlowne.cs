using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Kurier.Interfaces.Presenter;

namespace Kurier.Views.Menu
{
    public class VMenuGlowne
    {
        private MenuGlowneCentrala menu;
        private ICMLogowanie logowanieP;
        private ICMSamochody samochodyP;
        private ICMStatystyka statystykaP;
        private ICMKurierzy kurierzyP;
        private ICMPaczki paczkiP;

        public VMenuGlowne(ICMLogowanie logowanieP, ICMSamochody samochodyP, ICMStatystyka statystykaP, ICMKurierzy kurierzyP, ICMPaczki paczkiP)
        {
            this.logowanieP = logowanieP;
            this.samochodyP = samochodyP;
            this.statystykaP = statystykaP;
            this.kurierzyP = kurierzyP;
            this.paczkiP = paczkiP;
        }

        public void setMenuGlowneCentrala(MenuGlowneCentrala menu)
        {
            this.menu = menu;
        }

        public void wyswietlMenuGlowneCentrali(Models.DTO.Uzytkownik.DaneUzytkownika dane)
        {
            MenuGlowneCentrala.wyswietlOkno(this, dane);
        }

        public void wybranoWyloguj()
        {
            logowanieP.wybranoWylogujZCentrali();
        }

        public void wybranoPokazListeKurierow()
        {
            kurierzyP.wybranoPokazListeKurierow();
        }

        public void wybranoPokazListePaczek()
        {
            paczkiP.wybranoPokazListePaczek();
        }

        public void wybranoPokazListeSamochodow()
        {
            samochodyP.wybranoPokazListeSamochodow();
            //Presenters.Atrapa.PCentrSamochody.wybranoPokazListeSamochodow();
        }

        public void wybranoPokazNajczeszychKlientow()
        {
            statystykaP.wybranoPokazNajczestszychKlientow();
        }

        public void wybranoPokazNajczestszeMiasta()
        {
            statystykaP.wybranoPokazNajczestszeObszaryPaczek();
        }
    }
}