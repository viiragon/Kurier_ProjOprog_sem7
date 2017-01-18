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
    public partial class OknoSzczegolowKuriera : System.Web.UI.Page
    {
        private static VCentralaKurier controller;
        //public List<Models.DTO.Paczka.DanePaczki> paczki;
        private static DaneKuriera kurier;
        private static string message;

        protected void Page_Load(object sender, EventArgs e)
        {
            Pages.setCurrent(this);
            if (message != null)
            {
                phMessage.Visible = true;
                lMessage.Text = message;
            }
            if (kurier != null)
            {
                lImie.Text = kurier.Imie;
                lNazwisko.Text = kurier.Nazwisko;
                LKurierAdres.Text = kurier.Adres.getProperAddressString();
            }
        }

        public static void wyswietlOkno(VCentralaKurier caller, DaneKuriera dk, string messageArg)
        {
            controller = caller;
            kurier = dk;
            message = messageArg;
            Pages.loadPage("/Views/Menu/CentrKurier/OknoSzczegolowKuriera.aspx");
        }
    }
}