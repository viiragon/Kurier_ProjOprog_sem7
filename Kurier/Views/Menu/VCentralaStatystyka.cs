using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Kurier.Models.DTO.Statystyka;
using static Kurier.Models.DTO.Statystyka.StatystykaKlientow;

namespace Kurier.Views.Menu
{
    public class VCentralaStatystyka : Interfaces.View.IVCentralaStatystyka
    {
        private NajczestsiKlienci klienci;
        private Interfaces.Presenter.ICMStatystyka statystykaP;

        public VCentralaStatystyka(Interfaces.Presenter.ICMStatystyka statystykaP)
        {
            this.statystykaP = statystykaP;
        }

        public void setNajczestsiKlienci(NajczestsiKlienci klienci)
        {
            this.klienci = klienci;
        }

        public override void wyswietlOknoNajczestszychObszarowPaczek(StatystykaObszaru statystyka) { }
        public override void wyswietlOknoObciazeniaKurierow(ObciazenieKurierow statystyka) { }
        public override void wyswietlOknoStatystykPaczek(StatystykaPaczek statystyka) { }
        public override void wyswietlOknoNajczestszychKlientow(StatystykaKlientow statystyka)
        {
            List<DaneStatystykiKlienta> statystykiKlienta = statystyka.StatystykiKlienta;
            DaneStatystykiKlienta[] lista = new DaneStatystykiKlienta[statystykiKlienta.Count];
            for (int i = 0; i < lista.Length; i++)
            {
                lista[i] = statystykiKlienta[i];
            }
            NajczestsiKlienci.wyswietlOkno(this, lista);
        }
    }
}