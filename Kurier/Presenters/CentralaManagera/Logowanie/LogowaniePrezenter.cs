using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Kurier.Interfaces.Presenter;
using Kurier.Models.DTO.Uzytkownik;
using Kurier.Models.DataAccess;

namespace Kurier.Presenters.CentralaManager.Logowanie
{
    public class LogowaniePrezenter : ICMLogowanie
    {
        public static LogowaniePrezenter logowaniePrezenter = new LogowaniePrezenter();

        private Interfaces.View.IVCentralaLogowanie logowanie;
        private UzytkownicyModel uzytkownicy;
        public LogowaniePrezenter() {
            logowanie = Interfaces.View.IVCentralaLogowanie.createInstance(this);
            uzytkownicy = new UzytkownicyModel();
        }

        public void startCentrala()
        {
            logowanie.wyswietlFormularzLogowania();
        }

        public void wybranoWylogujZCentrali()
        {
            logowanie.wyswietlFormularzLogowania();
        }

        public void wybranoZalogujDoCentrali(DaneAuthUzytkownika dane)
        {
            //potrzebujemy sprawdzania po loginie
            if (dane.Login.Equals("corzel") && dane.Haslo.Equals("natak139l"))
            {
                uzytkownicy.ZalogujDoCentrali(dane);
                Models.DTO.Uzytkownik.DaneUzytkownika user = new Models.DTO.Uzytkownik.DaneUzytkownika();
                user.Imie = "Cichosław";
                user.Nazwisko = "Orzeł";
                user.UserId = 0;
                user.Telefon = 0700880;
                user.Uprawnienia = 0;
                user.Login = dane.Login;
                user.Haslo = dane.Haslo;
                Presenters.CentralaManager.PaczkiCM.PaczkiPrezenter paczkiP = new Presenters.CentralaManager.PaczkiCM.PaczkiPrezenter();
                logowanie.wyswietlMenuGlowneCentrali(user, new Presenters.CentralaManager.KurierzyCM.KurierzyPrezenter(paczkiP), new Presenters.CentralaManager.SamochodyCM.SamochodyPrezenter(), new Presenters.CentralaManager.StatystykiCM.StatystykiPrezenter(), paczkiP);
            }
            else
            {
                logowanie.wyswietlKomunikatOBlednychDanych();
            }
        }
    }
}