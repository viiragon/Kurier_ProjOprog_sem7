using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAPSNET.Views
{
    interface IVCentralaKurierzy
    {
        void wyswietlFormularzDodawaniaKuriera();
        void wyswietlFormularzEdycjiKuriera(Models.DaneKuriera kurier);
        void wyswietlOknoListyKurierow(Models.DaneKuriera[] kurierzy);
        void wyswietlOknoPrzypisywaniaKurieraDoPaczki(Models.DaneKuriera[] kurierzy);
        void wyswietlOknoPrzypisywaniaKurieraDoSamochodu(Models.DaneKuriera[] kurierzy);
    }
}
