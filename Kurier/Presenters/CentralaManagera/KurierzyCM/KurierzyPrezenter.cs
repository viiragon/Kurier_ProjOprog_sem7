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
    public class KurierzyPrezenter : ICMKurierzy
    {
        private Interfaces.View.IVCentralaKurierzy kurierzy;
        private KurierzyModel kurierzyModel;

        public KurierzyPrezenter(Interfaces.Presenter.ICMPaczki paczkiP)
        {
            kurierzy = Interfaces.View.IVCentralaKurierzy.createInstance(this, paczkiP);
            kurierzyModel = new KurierzyModel();
        }

        public void wybranoDodajKuriera()
        {
            throw new NotImplementedException();
        }

        public void wybranoEdytujKuriera(int id)
        {
            throw new NotImplementedException();
        }

        public void wybranoPokazListeKurierow()
        {
            throw new NotImplementedException();
        }

        public void wybranoZapiszEdycjeKuriera(DaneKuriera kurier)
        {
            throw new NotImplementedException();
        }

        public void wybranoZapiszNowegoKuriera(DaneKuriera kurier)
        {
            throw new NotImplementedException();
        }

        public void wybranoPokazSzczegolyKuriera(int id)
        {
            throw new NotImplementedException();
        }
    }
}