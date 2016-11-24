using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Kurier.Interfaces.Presenter;
using Kurier.Models.DTO.Paczka;
using Kurier.Models.DTO.Uzytkownik;
using Kurier.Views.Menu;
using Kurier.Models;

namespace Kurier.Presenters.KlientManager
{
    public class KlientPrezenter : IPKlient
    {
        public static KlientPrezenter klientPrezenter = new KlientPrezenter();

        private Interfaces.View.IVKlient ivKlient;
        private Models.DataAccess.PaczkaModel mPaczka;
        private DanePaczki[] paczki;

        KlientPrezenter() {
            ivKlient = Interfaces.View.IVKlient.createInstance(this);
            mPaczka = new Models.DataAccess.PaczkaModel();
        }

        public void startNadawca()
        {
            ivKlient.wyswietlFormularzLogowaniaKlienta();
        }

        public void wybranoLogowanieJakoKlient()
        {
            throw new NotImplementedException();
        }

        public void wybranoNadaniePaczki()
        {
            ivKlient.wyswietlFormularzNadaniaPaczki();
        }

        public void wybranoNadaniePaczkiBezLogowania()
        {
            ivKlient.wyswietlFormularzNadaniaPaczkiBezLogowania();
        }

        public void wybranoRejestracjaJakoKlient()
        {
            ivKlient.wyswietlOknoRejestracjiKlienta();
        }

        public void wybranoWylogujKlienta()
        {
            throw new NotImplementedException();
        }

        public void wybranoZalogujMnieJakoKlient(DaneUzytkownika dane)
        {
            Random r = new Random();
            if (dane.Login.Equals("eadam") && dane.Haslo.Equals("natak139m"))
            {
                Models.DTO.Uzytkownik.DaneUzytkownika user = new Models.DTO.Uzytkownik.DaneUzytkownika();
                user.Imie = "Ewa";
                user.Nazwisko = "Adamska";
                user.Id = 0;
                user.Telefon = 0700880;
                user.Uprawnienia = 0;
                user.Login = dane.Login;
                user.Haslo = dane.Haslo;
                paczki = mPaczka.PobierzListePaczek().ToArray();
                ivKlient.wyswietlMenuGlowneKlienta(user, paczki);
            }
            else
            {
                ivKlient.wyswietlKomunikatOBlednychDanychLogowania();
            }
        }

        public void wybranoZapiszDaneNadanejPaczki(DanePaczki paczka)
        {
            bool czyPoprawneDane = mPaczka.WalidujDanePaczki(paczka);
            if (czyPoprawneDane)
            {
                mPaczka.DodajPaczke(paczka);
                ivKlient.wyswietlKomunikatOPoprawnymNadaniuPaczki();
            }
        }

        public void wybranoZarejestrujMnieJakoKlient(DaneKlienta dane)
        {
            throw new NotImplementedException();
        }
    }
}