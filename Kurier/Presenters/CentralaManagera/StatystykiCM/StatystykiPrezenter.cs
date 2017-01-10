using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Kurier.Interfaces.Presenter;
using Kurier.Models.DataAccess;
using Kurier.Models.DTO.Statystyka;

namespace Kurier.Presenters.CentralaManager.StatystykiCM
{
    public class StatystykiPrezenter : ICMStatystyka
    {
        private Interfaces.View.IVCentralaStatystyka statystyka;
        private StatystykiModel statystykiModel;
        public StatystykiPrezenter()
        {
            statystyka = Interfaces.View.IVCentralaStatystyka.createInstance(this);
            statystykiModel = new StatystykiModel();
        }

        public void wybranoPokazNajczestszeObszaryPaczek()
        {
            StatystykaObszaru statystykaObszaru = statystykiModel.PobierzNajczestszeObszaryPaczek();
            statystyka.wyswietlOknoNajczestszychObszarowPaczek(statystykaObszaru);
        }

        public void wybranoPokazNajczestszychKlientow()
        {
            StatystykaKlientow statystykaKlientów = statystykiModel.PobierzStatystykeNajczestszychKlientow();
            statystyka.wyswietlOknoNajczestszychKlientow(statystykaKlientów);
        }

        public void wybranoPokazObciazenieKurierow()
        {
            ObciazenieKurierow obciazenieKurierow = statystykiModel.PobierzObciazenieKurierow();
            statystyka.wyswietlOknoObciazeniaKurierow(obciazenieKurierow);
        }

        public void wybranoPokazStatystykiPaczek()
        {
            StatystykaPaczek statystykaPaczek = statystykiModel.PobierzStatystykiPaczek();
            statystyka.wyswietlOknoStatystykPaczek(statystykaPaczek);
        }
    }
}