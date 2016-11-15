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
        void wyswietlOknoNajczestszychObszarowPaczek(Models.StatystykaObszaru statystyka);
        void wyswietlOknoObciazeniaKurierow(Models.ObciazenieKurierow statystyka);
        void wyswietlOknoStatystykPaczek(Models.StatystykaPaczek statystyka);
        void wyswietlOknoNajczestszychKlientow(StatystykaKlientow statystyka);
    }
}
