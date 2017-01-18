using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kurier.Views.Menu
{
    public partial class OknoSamochoduKuriera : System.Web.UI.Page
    {
        private static Kurier.VKurier controller;
        public static Models.DTO.Samochod.DaneSamochodu samochod;
        public static Models.DTO.Uzytkownik.DaneKuriera kurier;
        public static string komunikat;

        protected void Page_Load(object sender, EventArgs e)
        {
            Pages.setCurrent(this);
            if (controller != null)
            {
                controller.setOknoSamochoduKuriera(this);
            }
            if (komunikat != null)
            {
                phMessage.Visible = true;
                lMessage.Text = komunikat;
            }
            if (samochod != null)
            {
                lId.Text = samochod.Id.ToString();
                lMarka.Text = samochod.Marka;
                lModel.Text = samochod.Model;
                lRejestracja.Text = samochod.NumRejestracyjny;
                lStan.Text = samochod.Stan;
                lDataKontroli.Text = samochod.DataKontroli.getProperDateString();
            }
        }

        public static void wyswietlOkno(Kurier.VKurier caller, Models.DTO.Samochod.DaneSamochodu s,
            string komunikatArg, Models.DTO.Uzytkownik.DaneKuriera kurierArg)
        {
            samochod = s;
            kurier = kurierArg;
            controller = caller;
            komunikat = komunikatArg;
            Pages.loadPage("/Views/Menu/Kurier/OknoSamochoduKuriera.aspx");
        }
    }
}