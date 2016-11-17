using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurier.Interfaces.View
{
    public abstract class IVCentralaLogowanie
    {
        public static IVCentralaLogowanie createInstance() {
            return new Views.Menu.VLogowanieCentrali();
        }

        public abstract void wyswietlFormularzLogowania();
        public abstract void wyswietlKomunikatOBlednychDanych();
        public abstract void wyswietlMenuGlowneCentrali(Models.DTO.Uzytkownik.DaneUzytkownika dane);
    }
}
