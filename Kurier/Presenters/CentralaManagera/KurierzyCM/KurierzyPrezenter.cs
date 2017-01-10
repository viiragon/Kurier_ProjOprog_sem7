using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Kurier.Interfaces.Presenter;
using Kurier.Models.DTO.Uzytkownik;
using Kurier.Models.DataAccess;

namespace Kurier.Presenters.CentralaManager.KurierzyCM
{
    public class KurierzyPrezenter : ICMKurierzy
    {
        private Interfaces.View.IVCentralaKurierzy kurierzy;
        private KurierzyModel kurierzyModel;
        public KurierzyPrezenter()
        {
            kurierzy = Interfaces.View.IVCentralaKurierzy.createInstance(this);
            kurierzyModel = new KurierzyModel();
        }

        public void wybranoDodajKuriera()
        {
            kurierzy.wyswietlFormularzDodawaniaKuriera();
           // throw new NotImplementedException();
        }

        public void wybranoEdytujKuriera(int id)
        {
            DaneKuriera kurier = kurierzyModel.PobierzKuriera(id);
            kurierzy.wyswietlFormularzEdycjiKuriera(kurier);
        //    throw new NotImplementedException();
        }

        public void wybranoPokazListeKurierow()
        {
            DaneKuriera[] listaKurierow = kurierzyModel.PobierzListeKurierow().ToArray();      
            kurierzy.wyswietlOknoListyKurierow(listaKurierow);
         //   throw new NotImplementedException();
        }

        public void wybranoZapiszEdycjeKuriera(DaneKuriera kurier)
        {
            bool czydanepoprawne = kurierzyModel.WalidujDaneKuriera(kurier);
            if (czydanepoprawne)
            {
                throw new NotImplementedException();
            }
            
            throw new NotImplementedException();
        }

        public void wybranoZapiszNowegoKuriera(DaneKuriera kurier)
        {
            throw new NotImplementedException();
        }
    }
}