using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kurier.Views.Menu
{
    public class VLogowanieCentrali : Interfaces.View.IVCentralaLogowanie
    {
        private LogowanieCentrali logowanie;

        public void setLogowanieCentrali(LogowanieCentrali logowanie) {
            this.logowanie = logowanie;
        }

        public override void wyswietlFormularzLogowania()
        {
            LogowanieCentrali.wyswietlOkno(this);
        }
        public override void wyswietlKomunikatOBlednychDanych()
        {
        }
        public override void wyswietlMenuGlowneCentrali(Models.DTO.Uzytkownik.DaneUzytkownika dane)
        {
        }
    }
}