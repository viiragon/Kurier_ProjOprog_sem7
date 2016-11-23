using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kurier.Interfaces.Presenter
{
    public interface ICMStatystyka
    {
        void wybranoPokazNajczestszeObszaryPaczek();
        void wybranoPokazNajczestszychKlientow();
        void wybranoPokazObciazenieKurierow();
        void wybranoPokazStatystykiPaczek();
    }
}