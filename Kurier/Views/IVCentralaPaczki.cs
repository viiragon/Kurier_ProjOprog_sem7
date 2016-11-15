using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Kurier.Models.DTO;

namespace Kurier.Views
{
    interface IVCentralaPaczki
    {
        void wyswietlFormularzEdycjiStatusuPaczki(String[] statusy);
        void wyswietlOknoListyPaczek(DanePaczki[] paczki);
        void wyswietlOknoSzczegolowPaczki(DanePaczki paczka);
    }
}