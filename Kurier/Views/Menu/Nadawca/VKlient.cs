using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Kurier.Models.DTO.Paczka;
using Kurier.Models.DTO.Samochod;

namespace Kurier.Views.Menu
{
    public class VKlient : Interfaces.View.IVKlient
    {
        private LogowanieKlient logowanie;
        private NadaniePaczki nadanie;
        private MenuGlowneNadawcy menu;
        private Interfaces.Presenter.IPKlient presenter;

        public VKlient(Interfaces.Presenter.IPKlient presenter)
        {
            this.presenter = presenter;
        }

        public void setLogowanieKlient(LogowanieKlient logowanie)
        {
            this.logowanie = logowanie;
        }

        public void setNadawaniePaczki(NadaniePaczki nadanie)
        {
            this.nadanie = nadanie;
        }

        public void setMenuGlowne(MenuGlowneNadawcy menu)
        {
            this.menu = menu;
        }

        public void wybranoZaloguj(string login, string password)
        {
            Models.DTO.Uzytkownik.DaneUzytkownika dto = new Models.DTO.Uzytkownik.DaneUzytkownika();
            dto.Login = login;
            dto.Haslo = password;
            presenter.wybranoZalogujMnieJakoKlient(dto);
        }

        public void wybranoWyloguj()
        {
            presenter.wybranoWylogujKlienta();
        }

        public void wybranoNadajBezLogowania()
        {
            presenter.wybranoNadaniePaczkiBezLogowania();
        }

        public void wybranoNadaj()
        {
            presenter.wybranoNadaniePaczki();
        }

        public void wybranoZapiszNadanaPaczke(string adresat, string adresAdresata, string nadawca, string adresNadawcy)
        {
            DanePaczki paczka = new DanePaczki();
            paczka.AdresAdresata = new Models.DTO.Adres();
            paczka.AdresAdresata.Ulica = adresAdresata;
            paczka.AdresAdresata.KodPocztowy = "00-000";
            paczka.AdresAdresata.Miasto = "Warszawa";
            paczka.AdresAdresata.NumerMieszkania = "10";
            presenter.wybranoZapiszDaneNadanejPaczki(paczka);
        }

        public override void wyswietlFormularzLogowaniaKlienta()
        {
            LogowanieKlient.wyswietlOkno(this);
        }

        public override void wyswietlFormularzNadaniaPaczki()
        {
            NadaniePaczki.wyswietlOkno(this, true);
        }

        public override void wyswietlFormularzNadaniaPaczkiBezLogowania()
        {
            NadaniePaczki.wyswietlOkno(this, false);
        }

        public override void wyswietlKomunikatOBlednychDanychLogowania()
        {
            logowanie.wyswietlBladNiepoprawneDane();
        }

        public override void wyswietlOknoRejestracjiKlienta()
        {
            throw new NotImplementedException();
        }

        public override void wyswietlKomunikatOPoprawnymNadaniuPaczki()
        {
            nadanie.wyswietlKomunikatONadaniuPaczki();
        }

        public override void wyswietlMenuGlowneKlienta(Models.DTO.Uzytkownik.DaneUzytkownika klient, DanePaczki[] paczki)
        {
            MenuGlowneNadawcy.wyswietlOkno(this, klient);
        }
    }
}