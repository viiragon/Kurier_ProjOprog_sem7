using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestAPSNET.Views
{
    interface IVCentralaPaczki
    {
        void wyswietlFormularzEdycjiStatusuPaczki(String[] statusy);
        void wyswietlOknoListyPaczek(Models.DanePaczki[] paczki);
        void wyswietlOknoSzczegolowPaczki(Models.DanePaczki paczka);
    }
}