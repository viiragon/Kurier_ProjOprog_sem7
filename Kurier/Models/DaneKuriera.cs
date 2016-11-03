using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestAPSNET.Models
{
    public class DaneKuriera
    {
        private DaneUzytkownika uzytkownik { get; set; }
        private String lokalizacja { get; set; }
        private bool urlop { get; set; }

        public DaneKuriera(DaneUzytkownika uzytkownik, String lokalizacja, bool urlop) {
            this.uzytkownik = uzytkownik;
            this.lokalizacja = lokalizacja;
            this.urlop = urlop;
        }
    }
}