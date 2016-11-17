using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Kurier.Models.DTO.Samochod;

namespace Kurier.Views.Menu
{
    public class VCentralaSamochody : Interfaces.View.IVCentralaSamochody
    {
        private CentralaSamochody centralaSamochody;

        public void setCentralaSamochody(CentralaSamochody centralaSamochody)
        {
            this.centralaSamochody = centralaSamochody;
        }

        public override void aktualizujOknoSzczegolowSamochodu(DaneSamochodu samochod)
        {
           
        }

        public override void wyswietlOknoDodawaniaSamochodu()
        {
            CentralaSamochody.wyswietlOkno(this);
        }

        public override void wyswietlOknoListySamochodow(DaneSamochodu[] lista)
        {
           
        }

        public override void wyswietlOknoSzczegolowSamochodu(DaneSamochodu samochod)
        {
           
        }

        public override void wyswietlOknoWysylaniaZleceniaDoSerwisu(DaneSamochodu samochod)
        {
           
        }

    }
}