using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kurier.Models.DTO;
using Kurier.Models.DTO.Paczka;
using Kurier.Models.DTO.Samochod;

namespace Kurier.Views
{
    interface IVKurier
    {
        void wyswietlFormularzEdycjiStatusuPaczki(String[] statusy);
        void wyswietlFormularzLogowaniaJakoKurier();
        void wyswietlKomunikatOBlednychDanychLogowania();
        void wyswietlOknoKolejnegoPrzegladu(DateTime data);
        void wyswietlOknoListyZlecenKuriera(DanePaczki[] zlecenia);
        void wyswietlOknoPrzypisanegoSamochodu(DaneSamochodu samochod);
        void wyswietlOknoWydaniaPaczki(DanePaczki paczki);
    }
}
