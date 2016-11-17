using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Kurier.Models.DTO;
using Kurier.Models.DTO.Paczka;

namespace Kurier.Interfaces.View
{
    interface IVCentralaPaczki
    {
        void wyswietlFormularzEdycjiStatusuPaczki(String[] statusy);
        void wyswietlOknoListyPaczek(DanePaczki[] paczki);
        void wyswietlOknoSzczegolowPaczki(DanePaczki paczka);
    }
}