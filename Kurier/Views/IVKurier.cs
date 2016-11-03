using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAPSNET.Views
{
    interface IVKurier
    {
        void wyswietlFormularzEdycjiStatusuPaczki(String[] statusy);
        void wyswietlFormularzLogowaniaJakoKurier();
        void wyswietlKomunikatOBlednychDanychLogowania();
        void wyswietlOknoKolejnegoPrzegladu(DateTime data);
        void wyswietlOknoListyZlecenKuriera(Models.DanePaczki[] zlecenia);
        void wyswietlOknoPrzypisanegoSamochodu(Models.DaneSamochodu samochod);
        void wyswietlOknoWydaniaPaczki(Models.DanePaczki paczki);
    }
}
