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
        public static IVCentralaKurierzy createInstance(Presenter.ICMKurierzy kurierzyP, Presenter.ICMPaczki paczkiP)
        {
            return new Views.Menu.VCentralaKurier(kurierzyP, paczkiP);
        }
        public abstract void wyswietlFormularzDodawaniaKuriera();
        public abstract void wyswietlFormularzEdycjiKuriera(DaneKuriera kurier);
        public abstract void wyswietlOknoSzczegolowKuriera(DaneKuriera kurier, string message);
        public abstract void wyswietlOknoListyKurierow(DaneKuriera[] kurierzy);
        public abstract void wyswietlOknoPrzypisywaniaKurieraDoPaczki(DaneKuriera[] kurierzy, int idPaczki);
        public abstract void wyswietlOknoPrzypisywaniaKurieraDoSamochodu(DaneKuriera[] kurierzy, int idSamochodu);
    }
}
