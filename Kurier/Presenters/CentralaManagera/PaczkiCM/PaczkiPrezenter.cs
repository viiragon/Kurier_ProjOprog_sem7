using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Kurier.Interfaces.Presenter;
using Kurier.Models;
using Kurier.Models.DTO.Paczka;
using Kurier.Models.DataAccess;
using Kurier.Models.DTO.Uzytkownik;

namespace Kurier.Presenters.CentralaManager.PaczkiCM
{
    public class PaczkiPrezenter : ICMPaczki
    {
        private Interfaces.View.IVCentralaPaczki paczki;
        //Sprawdzic Kurirow dla paczek
        private Interfaces.View.IVCentralaKurierzy kurierzy;

        private PaczkaModel paczkaModel;
        private KurierzyModel kurierzyModel;

        public PaczkiPrezenter()
        {
            paczki = Interfaces.View.IVCentralaPaczki.createInstance(this);
            paczkaModel = new PaczkaModel();
            kurierzyModel = new KurierzyModel();
        }

        //String[]?
        public void wybranoEdytujStatusPaczki(int id)
        {
            DanePaczki paczka = paczkaModel.PobierzPaczke(id);
            //Status typu string[] ???
            Status statusP = paczka.Status;
            string dstatus = statusP.ToString();
            paczki.wyswietlFormularzEdycjiStatusuPaczki(new[] { dstatus });
        }

        public void wybranoPokazListePaczek()
        {
            DanePaczki[] lisaPaczek = paczkaModel.PobierzListePaczek().ToArray();
            paczki.wyswietlOknoListyPaczek(lisaPaczek);
        }

        public void wybranoPokazSzczegolyPaczki(int id)
        {
            DanePaczki paczka = paczkaModel.PobierzPaczke(id);
            paczki.wyswietlOknoSzczegolowPaczki(paczka);
        }

        //Metody w modelu
        public void wybranoPrzypiszKurieraDoPaczki(int idPaczki)
        {
            //paczki.
            
        }

        public void wybranoZapiszPowiazanieKurieraZPaczka(int idPaczki,int idKuriera)
        {
            DanePaczki paczki = paczkaModel.PobierzPaczke(idPaczki);
            DaneKuriera kurier = kurierzyModel.PobierzKuriera(idKuriera);
            bool poprawneDanePaczki = paczkaModel.WalidujDanePaczki(paczki);
            bool poprawneDaneKuriera = kurierzyModel.WalidujDaneKuriera(kurier);

            if (poprawneDanePaczki && poprawneDaneKuriera)
            {
                paczkaModel.PowiazKurieraIPaczke(idPaczki, idKuriera);
                //Komunikat
            }
            
        }

        public void wybranoZapiszStatusPaczkiDlaCentrali(Models.DTO.Paczka.Status status, int idPaczki)
        {
            DanePaczki paczki = paczkaModel.PobierzPaczke(idPaczki);
            bool poprawneDanePaczki = paczkaModel.WalidujDanePaczki(paczki);
            if (poprawneDanePaczki)
            {
                paczkaModel.ZmienStatusPaczki(status, idPaczki);
                //Komunikat
            }
        }

        //Sprawdzic
        public void wybranoPokazSzczegolyKurieraDlaPaczki(int id)
        {
            DanePaczki paczka = paczkaModel.PobierzPaczke(id);
            
            DaneKuriera kurier = kurierzyModel.PobierzKuriera(id);
            // kurierzyModel.PobierzListePaczekKuriera
            if (kurier == null)
            {
                throw new NotImplementedException();
               // paczki.wyswietlOknoSzczegolowPaczki(paczka);
            }
            else
            {
                paczki.wyswietlOknoSzczegolowPaczki(paczka);
               // throw new NotImplementedException();
            }            
           // kurierzy.wyswietlOknoSzczegolowKuriera(kurier, "Kurier: ");
            
          //  throw new NotImplementedException();
        }
    }
}