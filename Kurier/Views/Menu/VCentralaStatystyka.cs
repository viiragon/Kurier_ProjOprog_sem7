using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Kurier.Models.DTO.Statystyka;

namespace Kurier.Views.Menu
{
    public class VCentralaStatystyka : Interfaces.View.IVCentralaStatystyka
    {
        private NajczestsiKlienci klienci;

        public void setNajczestsiKlienci(NajczestsiKlienci klienci)
        {
            this.klienci = klienci;
        }

        public void wyswietlOknoNajczestszychObszarowPaczek(StatystykaObszaru statystyka) { }
        public void wyswietlOknoObciazeniaKurierow(ObciazenieKurierow statystyka) { }
        public void wyswietlOknoStatystykPaczek(StatystykaPaczek statystyka) { }
        public void wyswietlOknoNajczestszychKlientow(StatystykaKlientow statystyka)
        {
            NajczestsiKlienci.wyswietlOkno(this);
        }
    }
}