using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Kurier.Models.DTO.Uzytkownik;

namespace Kurier.Views.Menu.Kurier
{
    public class VCentralaKurier : Interfaces.View.IVCentralaKurierzy
    {
        private Interfaces.Presenter.ICMKurierzy kurierzyP;
        
        public VCentralaKurier(Interfaces.Presenter.ICMKurierzy kurierzyP)
        {
            this.kurierzyP = kurierzyP;
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
            throw new NotImplementedException();
        }

        public override void wyswietlOknoPrzypisywaniaKurieraDoPaczki(DaneKuriera[] kurierzy)
        {
            throw new NotImplementedException();
        }

        public override void wyswietlOknoPrzypisywaniaKurieraDoSamochodu(DaneKuriera[] kurierzy)
        {
            throw new NotImplementedException();
        }
    }
}