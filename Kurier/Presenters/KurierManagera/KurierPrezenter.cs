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

        KurierPrezenter()
            {
                ivKurier = Interfaces.View.IVKurier.createInstance(this);
                mKurier = new Models.DataAccess.KurierzyModel();
            }

        public void wybranoEdytujStatusPaczki(int id)
        {
            DanePaczki paczka = mPaczka.PobierzPaczke(id);
            //ivKurier.wyswietlFormularzEdycjiStatusuPaczki(paczka);
            //throw new NotImplementedException();
        }

        public void wybranoPokazDateKolejnegoPrzegladu()
        {
            ivKurier.wyswietlOknoKolejnegoPrzegladu(DateTime.Now);
          //  throw new NotImplementedException();
        }

        public void wybranoPokazListeZlecenKuriera()
        {
            //pobranie danych kuriera i paczki
            ivKurier.wyswietlOknoListyZlecenKuriera(kurier,paczki);
            throw new NotImplementedException();
        }

        public void wybranoPokazSamochodKuriera()
        {
            //dane samochodu
            ivKurier.wyswietlOknoPrzypisanegoSamochodu(samochod);
          //  throw new NotImplementedException();
        }

        public void wybranoPokazSzczegolyPaczkiDlaKuriera(int id)
        {
            DanePaczki paczka = mPaczka.PobierzPaczke(id);
            ivKurier.wyswietlOknoSzczegolowPaczkiDlaKuriera(paczka);
         //   throw new NotImplementedException();
        }

        public void wybranoWydajPaczke(DanePaczki paczka)
        {
            ivKurier.wyswietlOknoWydaniaPaczki(paczka);
         //   throw new NotImplementedException();
        }

        public void wybranoWylogujKuriera()
        {
            ivKurier.wyswietlFormularzLogowaniaJakoKurier();
         //   throw new NotImplementedException();
        }

        public void wybranoZalogujKuriera(DaneUzytkownika dane)
        {
            ivKurier.wyswietlFormularzLogowaniaJakoKurier();
            //throw new NotImplementedException();
        }

        public void wybranoZapiszStatusPaczki(Status status, int idPaczki)
        {
            mPaczka.ZmienStatusPaczki(status, idPaczki);
           // throw new NotImplementedException();
        }
    }
}