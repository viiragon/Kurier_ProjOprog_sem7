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
        private Interfaces.Presenter.IPKlient presenter;

        public VKlient(Interfaces.Presenter.IPKlient presenter)
        {
            this.presenter = presenter;
        }

        public void setLogowanieKlient(LogowanieKlient logowanie)
        {
            this.logowanie = logowanie;
        }

        public void wybranoZaloguj(string login, string password)
        {
            Models.DTO.Uzytkownik.DaneUzytkownika dto = new Models.DTO.Uzytkownik.DaneUzytkownika();
            dto.Login = login;
            dto.Haslo = password;
            presenter.wybranoZalogujMnieJakoKlient(dto);
        }

        public override void wyswietlFormularzLogowaniaKlienta()
        {
            LogowanieKlient.wyswietlOkno(this);
        }

        public override void wyswietlFormularzNadaniaPaczki()
        {
            throw new NotImplementedException();
        }

        public override void wyswietlFormularzNadaniaPaczkiBezLogowania()
        {
            throw new NotImplementedException();
        }

        public override void wyswietlKomunikatOBlednychDanychLogowania()
        {
            throw new NotImplementedException();
        }

        public override void wyswietlMenuGlowneKlienta(DanePaczki[] paczki)
        {
            throw new NotImplementedException();
        }

        public override void wyswietlOknoRejestracjiKlienta()
        {
            throw new NotImplementedException();
        }
    }
}