using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kurier.Models.DTO;
using Kurier.Models.DTO.Paczka;
using Kurier.Models.DTO.Samochod;

namespace Kurier.Interfaces.View
{
    public abstract class IVKurier
    {
        public static IVKurier createInstance(Presenter.IPKurier kurierP)
        {
            return new Views.Menu.VKurier(kurierP);
        }
        public abstract void wyswietlFormularzEdycjiStatusuPaczki(String[] statusy);
        public abstract void wyswietlFormularzLogowaniaJakoKurier();
        public abstract void wyswietlKomunikatOBlednychDanychLogowania();
        public abstract void wyswietlOknoKolejnegoPrzegladu(DateTime data);
        public abstract void wyswietlOknoListyZlecenKuriera(DanePaczki[] zlecenia);
        public abstract void wyswietlOknoPrzypisanegoSamochodu(DaneSamochodu samochod);
        public abstract void wyswietlOknoWydaniaPaczki(DanePaczki paczki);
    }
}
