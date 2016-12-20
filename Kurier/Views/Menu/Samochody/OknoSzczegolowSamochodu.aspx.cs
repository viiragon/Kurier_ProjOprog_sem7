using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kurier.Views.Menu
{
    public partial class OknoSzczegolowSamochodu : System.Web.UI.Page
    {
        private static VCentralaSamochody controller;
        public static Models.DTO.Samochod.DaneSamochodu samochod;
        public static Models.DTO.Uzytkownik.DaneKuriera kurier;
        public static string komunikat;

        protected void Page_Load(object sender, EventArgs e)
        {
            Pages.setCurrent(this);
            if (controller != null)
            {
                controller.setOknoSzczegolowSamochodu(this);
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
                if (kurier != null)
                {
                    lKurier.Text = kurier.Imie + " " + kurier.Nazwisko;
                }
                else
                {
                    lKurier.Text = "Brak";
                }
                lDataKontroli.Text = getProperDateString(samochod.DataKontroli);
            }
        }

        private string getProperDateString(DateTime date)
        {
            string day = date.Day > 9 ? "" + date.Day : "0" + date.Day;
            string month = date.Month > 9 ? "" + date.Month : "0" + date.Month;
            return day + "." + month + "." + date.Year;
        }

        public static void wyswietlOkno(VCentralaSamochody caller, Models.DTO.Samochod.DaneSamochodu s,
            string komunikatArg, Models.DTO.Uzytkownik.DaneKuriera kurierArg)
        {
            samochod = s;
            kurier = kurierArg;
            controller = caller;
            komunikat = komunikatArg;
            Pages.loadPage("/Views/Menu/Samochody/OknoSzczegolowSamochodu.aspx");
        }
        protected void onClickBtCarEdit(object sender, EventArgs e)
        {
            controller.wyswietlOknoEdycjiSamochodu(samochod);
        }
        protected void onClickBtDelete(object sender, EventArgs e)
        {

        }
        protected void onClickBtBindKurier(object sender, EventArgs e)
        {
            controller.wybranoPrzypiszKurieraDoSamochodu(samochod.Id);
        }
        protected void onClickBtSend(object sender, EventArgs e)
        {

        }
    }
}