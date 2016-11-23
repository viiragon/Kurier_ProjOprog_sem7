using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kurier.Models.DTO;
using Kurier.Models.DTO.Uzytkownik;

namespace Kurier.Interfaces.View
{
    public abstract class IVCentralaKurierzy
    {
        public static IVCentralaKurierzy createInstance(Presenter.ICMKurierzy kurierzyP)
        {
            throw new NotImplementedException();
        }
        public abstract void wyswietlFormularzDodawaniaKuriera();
        public abstract void wyswietlFormularzEdycjiKuriera(DaneKuriera kurier);
        public abstract void wyswietlOknoListyKurierow(DaneKuriera[] kurierzy);
        public abstract void wyswietlOknoPrzypisywaniaKurieraDoPaczki(DaneKuriera[] kurierzy);
        public abstract void wyswietlOknoPrzypisywaniaKurieraDoSamochodu(DaneKuriera[] kurierzy);
    }
}
