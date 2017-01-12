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
        private OknoNajczestszeMiasta miasta;
        private Interfaces.Presenter.ICMStatystyka statystykaP;

        public VCentralaStatystyka(Interfaces.Presenter.ICMStatystyka statystykaP)
        {
            this.statystykaP = statystykaP;
        }

        public void setNajczestsiKlienci(NajczestsiKlienci klienci)
        {
            this.klienci = klienci;
        }

        public void setNajczestszeMiasta(OknoNajczestszeMiasta miasta)
        {
            this.miasta = miasta;
        }

        public override void wyswietlOknoNajczestszychObszarowPaczek(StatystykaObszaru statystyka) {
            List<StatystykaObszaru.DaneObszaru> ListaObszarow = statystyka.ListaObszarow;
            StatystykaObszaru.DaneObszaru[] lista = new StatystykaObszaru.DaneObszaru[ListaObszarow.Count];
            for (int i = 0; i < lista.Length; i++)
            {
                lista[i] = ListaObszarow[i];
            }
            OknoNajczestszeMiasta.wyswietlOkno(this, lista);
        }
        public override void wyswietlOknoObciazeniaKurierow(ObciazenieKurierow statystyka) { }
        public override void wyswietlOknoStatystykPaczek(StatystykaPaczek statystyka) { }
        public override void wyswietlOknoNajczestszychKlientow(StatystykaKlientow statystyka)
        {
            List<StatystykaKlientow.DaneStatystykiKlienta> statystykiKlienta = statystyka.StatystykiKlienta;
            StatystykaKlientow.DaneStatystykiKlienta[] lista = new StatystykaKlientow.DaneStatystykiKlienta[statystykiKlienta.Count];
            for (int i = 0; i < lista.Length; i++)
            {
                lista[i] = statystykiKlienta[i];
            }
            NajczestsiKlienci.wyswietlOkno(this, lista);
        }
    }
}