using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Kurier.Models.DTO.Paczka;

namespace Kurier.Views.Menu
{
    public class VCentralaPaczki : Interfaces.View.IVCentralaPaczki
    {
        private CentralaPaczki centralaPaczki;
        private Interfaces.Presenter.ICMPaczki paczkiP;

        public VCentralaPaczki(Interfaces.Presenter.ICMPaczki paczkiP)
        {
            this.paczkiP = paczkiP;
        }

        public void setCentralaPaczki(CentralaPaczki centralaPaczki)
        {
            this.centralaPaczki = centralaPaczki;
        }

        public override void wyswietlFormularzEdycjiStatusuPaczki(string[] statusy)
        {
            throw new NotImplementedException();
        }

        public override void wyswietlOknoListyPaczek(DanePaczki[] paczki)
        {
            CentralaPaczki.wyswietlOkno(this, paczki);
        }

        public override void wyswietlOknoSzczegolowPaczki(DanePaczki paczka)
        {
            OknoSzczegolowPaczki.wyswietlOkno(this, paczka);
        }

        public void wybranoSzczegolyPaczki(int id)
        {
            paczkiP.wybranoPokazSzczegolyPaczki(id);
        }

        public void wybranoKurierPaczki(int id)
        {
            paczkiP.wybranoPokazSzczegolyKurieraDlaPaczki(id);
        }
    }
}