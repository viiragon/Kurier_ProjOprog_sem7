using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Kurier.Models.DTO.Paczka;
using Kurier.Models.DTO.Samochod;

namespace Kurier.Views.Menu.Kurier
{
    public class VKurier : Interfaces.View.IVKurier
    {
        private OknoLogowanieKurier logowanie;
        private Kurier.MenuGlowneKurier menuKurier;
        private Interfaces.Presenter.IPKurier presenter;

        public VKurier(Interfaces.Presenter.IPKurier presenter)
        {
            this.presenter = presenter;
        }

        public void setOknoLogowanieKurier(OknoLogowanieKurier logowanie)
        {
            this.logowanie = logowanie;
        }

        public void setMenuGlowneKurier(Kurier.MenuGlowneKurier menuKurier)
        {
            this.menuKurier = menuKurier;
        }

        public void wybranoZaloguj(string login, string password)
        {
            Models.DTO.Uzytkownik.DaneKuriera dto = new Models.DTO.Uzytkownik.DaneKuriera();
            dto.Login = login;
            dto.Haslo = password;
            presenter.wybranoZalogujKuriera(dto);
        }

        public void wybranoWyloguj()
        {
            presenter.wybranoWylogujKuriera();
        }

        public override void wyswietlFormularzEdycjiStatusuPaczki(string[] statusy)
        {
            throw new NotImplementedException();
        }

        public override void wyswietlFormularzLogowaniaJakoKurier()
        {
            OknoLogowanieKurier.wyswietlOkno(this);
        }

        public override void wyswietlKomunikatOBlednychDanychLogowania()
        {
            throw new NotImplementedException();
        }

        public override void wyswietlOknoKolejnegoPrzegladu(DateTime data)
        {
            throw new NotImplementedException();
        }

        public override void wyswietlOknoListyZlecenKuriera(Models.DTO.Uzytkownik.DaneUzytkownika dane, DanePaczki[] zlecenia)
        {
            Kurier.MenuGlowneKurier.wyswietlOkno(this, dane, zlecenia);
        }

        public override void wyswietlOknoListyZlecenKurieraZKomunikatemOPrzegladzie(Models.DTO.Uzytkownik.DaneUzytkownika dane, DanePaczki[] zlecenia, DaneSamochodu samochod)
        {
            Kurier.MenuGlowneKurier.wyswietlOknoIKomunikatOPrzegladzie(this, dane, zlecenia, samochod);
        }

        public override void wyswietlOknoPrzypisanegoSamochodu(DaneSamochodu samochod)
        {
            throw new NotImplementedException();
        }

        public override void wyswietlOknoWydaniaPaczki(DanePaczki paczki)
        {
            throw new NotImplementedException();
        }

        public override void wyswietlOknoSzczegolowPaczkiDlaKuriera(DanePaczki paczka)
        {
            throw new NotImplementedException();
        }
    }
}