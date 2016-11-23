using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kurier.Models.DTO;
using Kurier.Models.DTO.Statystyka;

namespace Kurier.Interfaces.View
{
    public abstract class IVCentralaStatystyka
    {
        public static IVCentralaStatystyka createInstance(Interfaces.Presenter.ICMStatystyka statystykaP)
        {
            return new Views.Menu.VCentralaStatystyka(statystykaP);
        }
        public abstract void wyswietlOknoNajczestszychObszarowPaczek(StatystykaObszaru statystyka);
        public abstract void wyswietlOknoObciazeniaKurierow(ObciazenieKurierow statystyka);
        public abstract void wyswietlOknoStatystykPaczek(StatystykaPaczek statystyka);
        public abstract void wyswietlOknoNajczestszychKlientow(StatystykaKlientow statystyka);
    }
}
