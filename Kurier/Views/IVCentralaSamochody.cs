using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAPSNET.Views
{
    interface IVCentralaSamochody
    {
        void aktualizujOknoSzczegolowSamochodu(Models.DaneSamochodu samochod);
        void wyswietlOknoDodawaniaSamochodu();
        void wyswietlOknoListySamochodow(Models.DaneSamochodu[] lista);
        void wyswietlOknoSzczegolowSamochodu(Models.DaneSamochodu samochod);
        void wyswietlOknoWysylaniaZleceniaDoSerwisu(Models.DaneSamochodu samochod);
    }
}
