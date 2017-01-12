using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kurier.Models.DTO;
using Kurier.Models.DTO.Samochod;

namespace Kurier.Interfaces.View
{
    public abstract class IVCentralaSamochody
    {

        public static IVCentralaSamochody createInstance(Presenter.ICMSamochody samochodyP)
        {
            return new Views.Menu.VCentralaSamochody(samochodyP);
        }
        public abstract void aktualizujOknoSzczegolowSamochodu(DaneSamochodu samochod);
        public abstract void wyswietlOknoDodawaniaSamochodu();
        public abstract void wyswietlOknoListySamochodow(DaneSamochodu[] lista, string komunikat);
        public abstract void wyswietlOknoSzczegolowSamochodu(DaneSamochodu samochod, Models.DTO.Uzytkownik.DaneKuriera kurier);
        public abstract void wyswietlOknoSzczegolowSamochoduZKomunikatem(DaneSamochodu samochod, string komunikat, Models.DTO.Uzytkownik.DaneKuriera kurier);
        public abstract void wyswietlOknoWysylaniaZleceniaDoSerwisu(DaneSamochodu samochod);
        public abstract void wyswietlOknoPrzypisaniaSamochoduDoKuriera(int idSamochodu, Models.DTO.Uzytkownik.DaneKuriera[] kurierzy);
    }
}
