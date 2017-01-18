using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Kurier.Interfaces.Presenter;
using Kurier.Views.Menu;
using Kurier.Models;
using Kurier.Models.DTO.Paczka;
using Kurier.Models.DTO.Uzytkownik;

namespace Kurier.Presenters.KurierManager
{
    public class KurierPrezenter : IPKurier
    {

        public static KurierPrezenter kurierPrezenter = new KurierPrezenter();

        private Kurier.Interfaces.View.IVKurier ivKurier;
        private Models.DataAccess.KurierzyModel mKurier;
        private Models.DataAccess.PaczkaModel mPaczka;
        private DaneKuriera[] kurierzy;
        private DaneKuriera kurier;
        private DanePaczki[] paczki;
        private Models.DTO.Samochod.DaneSamochodu samochod;

        public KurierPrezenter()
        {
            ivKurier = Interfaces.View.IVKurier.createInstance(this);
            mKurier = new Models.DataAccess.KurierzyModel();
            mPaczka = new Models.DataAccess.PaczkaModel();
        }

        public void wybranoEdytujStatusPaczki(int id)
        {
            DanePaczki paczka = mPaczka.PobierzPaczke(id);
            //ivKurier.wyswietlFormularzEdycjiStatusuPaczki(paczka);
        }

        public void wybranoPokazDateKolejnegoPrzegladu()
        {
            ivKurier.wyswietlOknoKolejnegoPrzegladu(DateTime.Now);
        }

        public void wybranoPokazListeZlecenKuriera()
        {
            //pobranie danych kuriera i paczki
            ivKurier.wyswietlOknoListyZlecenKuriera(kurier,paczki, null);
        }

        public void wybranoPokazSamochodKuriera()
        {
            //dane samochodu
            ivKurier.wyswietlOknoPrzypisanegoSamochodu(samochod);
        }

        public void wybranoPokazSzczegolyPaczkiDlaKuriera(int id)
        {
            DanePaczki paczka = mPaczka.PobierzPaczke(id);
            ivKurier.wyswietlOknoSzczegolowPaczkiDlaKuriera(paczka);
        }

        public void wybranoWydajPaczke(DanePaczki paczka)
        {
            ivKurier.wyswietlOknoWydaniaPaczki(paczka);
        }

        public void wybranoWylogujKuriera()
        {
            ivKurier.wyswietlFormularzLogowaniaJakoKurier();
        }

        public void wybranoZalogujKuriera(DaneUzytkownika dane)
        {
            ivKurier.wyswietlFormularzLogowaniaJakoKurier();
        }

        public void wybranoZapiszStatusPaczki(Status status, int idPaczki)
        {
            mPaczka.ZmienStatusPaczki(status, idPaczki);
        }
    }
}