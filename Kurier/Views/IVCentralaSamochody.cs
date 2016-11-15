using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kurier.Models.DTO;

namespace Kurier.Views
{
    interface IVCentralaSamochody
    {
        void aktualizujOknoSzczegolowSamochodu(DaneSamochodu samochod);
        void wyswietlOknoDodawaniaSamochodu();
        void wyswietlOknoListySamochodow(DaneSamochodu[] lista);
        void wyswietlOknoSzczegolowSamochodu(DaneSamochodu samochod);
        void wyswietlOknoWysylaniaZleceniaDoSerwisu(DaneSamochodu samochod);
    }
}
