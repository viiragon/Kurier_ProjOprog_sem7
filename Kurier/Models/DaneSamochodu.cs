using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestAPSNET.Models
{
    public class DaneSamochodu
    {
        private int kierowcaId { get; set; }
        private String numRejestracyjny { get; set; }
        private String stan { get; set; }

        public DaneSamochodu(int kierowcaId, String numRejestracyjny, String stan) {
            this.kierowcaId = kierowcaId;
            this.numRejestracyjny = numRejestracyjny;
            this.stan = stan;
        }
    }
}