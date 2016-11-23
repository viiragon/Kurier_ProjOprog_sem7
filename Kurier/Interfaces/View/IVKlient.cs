using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurier.Interfaces.View
{
    public abstract class IVKlient
    {
        public static IVKlient createInstance(Presenter.IPKlient klientP)
        {
            throw new NotImplementedException();
        }
        public abstract void wyswietlFormularzLogowaniaKlienta();
        public abstract void wyswietlFormularzNadaniaPaczki();
        public abstract void wyswietlFormularzNadaniaPaczkiBezLogowania();
        public abstract void wyswietlKomunikatOBlednychDanychLogowania();
        public abstract void wyswietlMenuGlowneKlienta(Models.DTO.Paczka.DanePaczki[] paczki);
        public abstract void wyswietlOknoRejestracjiKlienta();
    }
}
