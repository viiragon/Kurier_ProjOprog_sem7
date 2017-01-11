using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Kurier.Interfaces.Presenter;
using Kurier.Models.DTO.Uzytkownik;
using Kurier.Models.DataAccess;
using Kurier.Models.DTO.Paczka;

namespace Kurier.Presenters.CentralaManager.KurierzyCM
{
    public class KurierzyPrezenter : IPKurier
    {

        private Interfaces.View.IVKurier ivKurier;
        private KurierzyModel kurierzyModel;

        public static KurierzyPrezenter kurierzyPrezenter = new KurierzyPrezenter();

        public KurierzyPrezenter()
        {
            ivKurier = Interfaces.View.IVKurier.createInstance(this);
            kurierzyModel = new KurierzyModel();
        }

        public void wybranoEdytujStatusPaczki(int id)
        {
            throw new NotImplementedException();
        }

        public void wybranoPokazDateKolejnegoPrzegladu()
        {
            throw new NotImplementedException();
        }

        public void wybranoPokazListeZlecenKuriera()
        {
            throw new NotImplementedException();
        }

        public void wybranoPokazSamochodKuriera()
        {
            throw new NotImplementedException();
        }

        public void wybranoPokazSzczegolyPaczkiDlaKuriera(int id)
        {
            throw new NotImplementedException();
        }

        public void wybranoWydajPaczke(DanePaczki paczka)
        {
            throw new NotImplementedException();
        }

        public void wybranoWylogujKuriera()
        {
            throw new NotImplementedException();
        }

        public void wybranoZalogujKuriera(DaneUzytkownika dane)
        {
            throw new NotImplementedException();
        }

        public void wybranoZapiszStatusPaczki(Status status, int idPaczki)
        {
            throw new NotImplementedException();
        }
    }
}