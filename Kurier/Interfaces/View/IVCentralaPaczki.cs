using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Kurier.Models.DTO;
using Kurier.Models.DTO.Paczka;

namespace Kurier.Interfaces.View
{
    public abstract class IVCentralaPaczki
    {
        public static IVCentralaPaczki createInstance(Presenter.ICMPaczki paczkiP)
        {
            return new Views.Menu.VCentralaPaczki(paczkiP);
        }
        public abstract void wyswietlFormularzEdycjiStatusuPaczki(String[] statusy);
        public abstract void wyswietlOknoListyPaczek(DanePaczki[] paczki);
        public abstract void wyswietlOknoSzczegolowPaczki(DanePaczki paczka);
    }
}