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
        private OknoSamochoduKuriera szczegolySamochodu;
        private Interfaces.Presenter.IPKurier presenter;

        private Models.DTO.Uzytkownik.DaneKuriera kurier;

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

        public void setOknoSamochoduKuriera(OknoSamochoduKuriera szczegolySamochodu)
        {
            this.szczegolySamochodu = szczegolySamochodu;
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

        public void wybranoPokazSamochod()
        {
            presenter.wybranoPokazSamochodKuriera();
        }

        public void wybranoWydaj(DanePaczki paczka)
        {
            Status status = new Status
            {
                Id = paczka.Status.Id,
                KodStatusu = (int)StatusEnum.WDrodze,
                Czas = paczka.Status.Czas,
                Kurier = paczka.Status.Kurier
            };
            presenter.wybranoZapiszStatusPaczki(status, paczka.Id);
        }

        public void wybranoDorecz(DanePaczki paczka)
        {
            Status status = new Status
            {
                Id = paczka.Status.Id,
                KodStatusu = (int)StatusEnum.Doreczona,
                Czas = paczka.Status.Czas,
                Kurier = paczka.Status.Kurier
            };
            presenter.wybranoZapiszStatusPaczki(status, paczka.Id);
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

        public override void wyswietlOknoListyZlecenKuriera(Models.DTO.Uzytkownik.DaneUzytkownika dane, DanePaczki[] zlecenia, string komunikat)
        {
            Kurier.MenuGlowneKurier.wyswietlOkno(this, dane, zlecenia, komunikat);
            kurier = dane as Models.DTO.Uzytkownik.DaneKuriera;
        }

        public override void wyswietlOknoListyZlecenKurieraZKomunikatemOPrzegladzie(Models.DTO.Uzytkownik.DaneUzytkownika dane, DanePaczki[] zlecenia, DaneSamochodu samochod, string komunikat)
        {
            Kurier.MenuGlowneKurier.wyswietlOknoIKomunikatOPrzegladzie(this, dane, zlecenia, samochod, komunikat);
        }

        public override void wyswietlOknoPrzypisanegoSamochodu(DaneSamochodu samochod)
        {
            OknoSamochoduKuriera.wyswietlOkno(this, samochod, null, kurier);
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