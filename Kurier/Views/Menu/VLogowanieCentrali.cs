using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kurier.Views.Menu
{
    public class VLogowanieCentrali : Interfaces.View.IVCentralaLogowanie
    {
        private LogowanieCentrali logowanie;
        private Interfaces.Presenter.ICMLogowanie presenter;

        public VLogowanieCentrali(Interfaces.Presenter.ICMLogowanie presenter)
        {
            this.presenter = presenter;
        }

        public void setLogowanieCentrali(LogowanieCentrali logowanie) {
            this.logowanie = logowanie;
        }

        public void wybranoZaloguj(string login, string password) 
        {
            Models.DTO.Uzytkownik.DaneAuthUzytkownika dto = new Models.DTO.Uzytkownik.DaneAuthUzytkownika();
            dto.Login = login;
            dto.Haslo = password;
            presenter.wybranoZalogujDoCentrali(dto);
        }

        public override void wyswietlFormularzLogowania()
        {
            LogowanieCentrali.wyswietlOkno(this);
        }
        public override void wyswietlKomunikatOBlednychDanych()
        {
            logowanie.wyswietlBladNiepoprawneDane();
        }
        public override void wyswietlMenuGlowneCentrali(Models.DTO.Uzytkownik.DaneUzytkownika dane, 
            Interfaces.Presenter.ICMKurierzy kurierzyP, 
            Interfaces.Presenter.ICMSamochody samochodyP, 
            Interfaces.Presenter.ICMStatystyka statystykaP, 
            Interfaces.Presenter.ICMPaczki paczkiP)
        {
            new VMenuGlowne(presenter,
                samochodyP,
                statystykaP,
                kurierzyP, paczkiP).wyswietlMenuGlowneCentrali(dane);
        }
    }
}