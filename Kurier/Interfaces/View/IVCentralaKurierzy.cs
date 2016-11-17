using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kurier.Models.DTO;
using Kurier.Models.DTO.Uzytkownik;

namespace Kurier.Interfaces.View
{
    interface IVCentralaKurierzy
    {
        void wyswietlFormularzDodawaniaKuriera();
        void wyswietlFormularzEdycjiKuriera(DaneKuriera kurier);
        void wyswietlOknoListyKurierow(DaneKuriera[] kurierzy);
        void wyswietlOknoPrzypisywaniaKurieraDoPaczki(DaneKuriera[] kurierzy);
        void wyswietlOknoPrzypisywaniaKurieraDoSamochodu(DaneKuriera[] kurierzy);
    }
}
