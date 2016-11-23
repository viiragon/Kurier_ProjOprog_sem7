using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Kurier.Interfaces.Presenter;

namespace Kurier.Interfaces.View
{
    public abstract class IVCentralaLogowanie
    {
        public static IVCentralaLogowanie createInstance(Presenter.ICMLogowanie presenter) {
            return new Views.Menu.VLogowanieCentrali(presenter);
        }
        public abstract void wyswietlFormularzLogowania();
        public abstract void wyswietlKomunikatOBlednychDanych();
        public abstract void wyswietlMenuGlowneCentrali(Models.DTO.Uzytkownik.DaneUzytkownika dane, ICMKurierzy kurierzyP, ICMSamochody samochodyP, ICMStatystyka statystykaP, ICMPaczki paczkiP);
    }
}
