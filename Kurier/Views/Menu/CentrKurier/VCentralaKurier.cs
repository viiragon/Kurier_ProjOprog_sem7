using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Kurier.Models.DTO.Uzytkownik;

namespace Kurier.Views.Menu
{
    public class VCentralaKurier : Interfaces.View.IVCentralaKurierzy
    {
        private Interfaces.Presenter.ICMKurierzy kurierzyP;
        private Interfaces.Presenter.ICMPaczki paczkiP;
        private OknoSzczegolowKuriera szczegoly;
        private OknoListyKurierow lista;
        private OknoPrzypisywaniaKurieraDoPaczki doPaczki;
        
        public VCentralaKurier(Interfaces.Presenter.ICMKurierzy kurierzyP, Interfaces.Presenter.ICMPaczki paczkiP)
        {
            this.kurierzyP = kurierzyP;
            this.paczkiP = paczkiP;
        }

        public void setOknoSzczegolow(OknoSzczegolowKuriera okno)
        {
            szczegoly = okno;
        }

        public void setOknoListy(OknoListyKurierow okno)
        {
            lista = okno;
        }

        public void setOknoDoPaczki(OknoPrzypisywaniaKurieraDoPaczki okno)
        {
            doPaczki = okno;
        }

        public void wybranoWyswietlSzczegoly(int id)
        {
            kurierzyP.wybranoPokazSzczegolyKuriera(id);
        }

        public void wybranoPrzypisz(int idKuriera, int idPaczki)
        {
            paczkiP.wybranoZapiszPowiazanieKurieraZPaczka(idPaczki, idKuriera);
        }

        public override void wyswietlFormularzDodawaniaKuriera()
        {
            throw new NotImplementedException();
        }

        public override void wyswietlFormularzEdycjiKuriera(DaneKuriera kurier)
        {
            throw new NotImplementedException();
        }

        public override void wyswietlOknoListyKurierow(DaneKuriera[] kurierzy)
        {
            OknoListyKurierow.wyswietlOkno(this, kurierzy);
        }

        public override void wyswietlOknoPrzypisywaniaKurieraDoPaczki(DaneKuriera[] kurierzy, int idPaczki)
        {
            OknoPrzypisywaniaKurieraDoPaczki.wyswietlOkno(this, kurierzy, idPaczki);
        }

        public override void wyswietlOknoPrzypisywaniaKurieraDoSamochodu(DaneKuriera[] kurierzy, int idSamochodu)
        {
            throw new NotImplementedException();
        }

        public override void wyswietlOknoSzczegolowKuriera(DaneKuriera kurier, string message)
        {
            OknoSzczegolowKuriera.wyswietlOkno(this, kurier, message);
        }
    }
}