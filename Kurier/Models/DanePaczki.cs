using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestAPSNET.Models
{
    public class DanePaczki
    {
        private String adres { get; set; }
        private String czasObslugi { get; set; }
        private String historia { get; set; }
        private String status { get; set; }

        public DanePaczki(String adres, String czasObslugi, String historia, String status) {
            this.adres = adres;
            this.czasObslugi = czasObslugi;
            this.historia = historia;
            this.status = status;
        }
    }
}