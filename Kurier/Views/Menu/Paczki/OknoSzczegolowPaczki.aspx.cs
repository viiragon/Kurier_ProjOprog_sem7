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

            if (paczka != null)
            {
                lAdresat.Text = paczka.AdresAdresata.getProperAddressString();
                if (paczka.PoczatekObslugi.HasValue)
                {
                    lNadana.Text = paczka.PoczatekObslugi.Value.getProperDateString();
                }
                if (paczka.KoniecObslugi.HasValue)
                {
                    lOdebrana.Text = paczka.KoniecObslugi.Value.getProperDateString();
                }
                else
                {
                    lOdebrana.Text = "Jeszcze nie dostarczona";
                }
                if (kurier != null)
                {
                    phKurier.Visible = true;
                    phBrakKuriera.Visible = false;
                    lImie.Text = kurier.Imie;
                    lNazwisko.Text = kurier.Nazwisko;
                    LKurierAdres.Text = kurier.Adres.getProperAddressString();
                }
                else
                {
                    phKurier.Visible = false;
                    phBrakKuriera.Visible = true;
                }
            }
        }

        public static void wyswietlOkno(VCentralaPaczki caller, DanePaczki dp)
        {
            controller = caller;
            paczka = dp;
            if (paczka != null && paczka.Status != null)
            {
                kurier = paczka.Status.Kurier;
            }
            Pages.loadPage("/Views/Menu/Paczki/OknoSzczegolowPaczki.aspx");
        }
    }
}