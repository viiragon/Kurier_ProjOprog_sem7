using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Kurier.Models.DTO.Paczka;
using Kurier.Models.DTO.Samochod;

namespace Kurier.Views.Menu
{
    public class VKurier : Interfaces.View.IVKurier
    {
        private LogowanieKurier logowanie;
        private Interfaces.Presenter.IPKurier presenter;

        public VKurier(Interfaces.Presenter.IPKurier presenter)
        {
            this.presenter = presenter;
        }

        public void setLogowanieKurier(LogowanieKurier logowanie)
        {
            this.logowanie = logowanie;
        }

        public void wybranoZaloguj(string login, string password)
        {
            Models.DTO.Uzytkownik.DaneKuriera dto = new Models.DTO.Uzytkownik.DaneKuriera();
            dto.Login = login;
            dto.Haslo = password;
            presenter.wybranoZalogujKuriera(dto);
        }

        public override void wyswietlFormularzEdycjiStatusuPaczki(string[] statusy)
        {
            throw new NotImplementedException();
        }

        public override void wyswietlFormularzLogowaniaJakoKurier()
        {
            LogowanieKurier.wyswietlOkno(this);
        }

        public override void wyswietlKomunikatOBlednychDanychLogowania()
        {
            throw new NotImplementedException();
        }

        public override void wyswietlOknoKolejnegoPrzegladu(DateTime data)
        {
            throw new NotImplementedException();
        }

        public override void wyswietlOknoListyZlecenKuriera(DanePaczki[] zlecenia)
        {
            throw new NotImplementedException();
        }

        public override void wyswietlOknoPrzypisanegoSamochodu(DaneSamochodu samochod)
        {
            throw new NotImplementedException();
        }

        public override void wyswietlOknoWydaniaPaczki(DanePaczki paczki)
        {
            throw new NotImplementedException();
        }
    }
}