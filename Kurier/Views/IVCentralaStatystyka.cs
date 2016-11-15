using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kurier.Models.DTO;

namespace Kurier.Views
{
    interface IVCentralaStatystyka
    {
        void wyswietlOknoNajczestszychObszarowPaczek(StatystykaObszaru statystyka);
        void wyswietlOknoObciazeniaKurierow(ObciazenieKurierow statystyka);
        void wyswietlOknoStatystykPaczek(StatystykaPaczek statystyka);
        void wyswietlOknoNajczestszychKlientow(StatystykaKlientow statystyka);
    }
}
