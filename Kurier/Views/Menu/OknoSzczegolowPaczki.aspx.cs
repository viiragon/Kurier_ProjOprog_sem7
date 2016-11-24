using Kurier.Models.DTO.Paczka;
using Kurier.Models.DTO.Uzytkownik;
using Kurier.Presenters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kurier.Views.Menu
{
    public partial class OknoSzczegolowPaczki : System.Web.UI.Page
    {
        private static VCentralaPaczki controller;
        //public List<Models.DTO.Paczka.DanePaczki> paczki;
        public static DanePaczki paczka;
        public static DaneKuriera kurier;

        protected void Page_Load(object sender, EventArgs e)
        {
            Pages.setCurrent(this);
          
            rptPaczki.DataSource = new DanePaczki[1] { paczka };
            rptPaczki.DataBind();

            rptKurier.DataSource = new DaneKuriera[1] { kurier };
            rptKurier.DataBind();
        }

        public static void wyswietlOkno(VCentralaPaczki caller, DanePaczki dp)
        {
            controller = caller;
            paczka = dp;
            kurier = dp.Status.KodStatusu == 0 ? Atrapa.daneKuriera1 : Atrapa.daneKuriera2;
            Pages.loadPage("/Views/Menu/OknoSzczegolowPaczki.aspx");
        }
    }
}