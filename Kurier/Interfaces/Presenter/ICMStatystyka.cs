using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kurier.Interfaces.Presenter
{
    public abstract class ICMStatystyka
    {
        public abstract void wybranoPokazNajczestszeObszaryPaczek();
        public abstract void wybranoPokazNajczestszychKlientow();
        public abstract void wybranoPokazObciazenieKurierow();
        public abstract void wybranoPokazStatystykiPaczek();
    }
}