using Kurier.Models.DTO.Paczka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kurier.Views.Menu.Kurier
{
    public partial class MenuGlowneKurier : System.Web.UI.Page
    {
        private static VKurier controller;
        public static DanePaczki[] paczki;
        public static Models.DTO.Samochod.DaneSamochodu samochod = null;
        private static Models.DTO.Uzytkownik.DaneUzytkownika dane;

        protected void Page_Load(object sender, EventArgs e)
        {
            Pages.setCurrent(this);
            if (controller != null)
            {
                controller.setMenuGlowneKurier(this);
            }
            if (!IsPostBack)
            {
                rptZlecenia.DataSource = paczki;
                rptZlecenia.DataBind();
                lUser.Text = dane.Imie + " " + dane.Nazwisko;
            }
            if (samochod != null)
            {
                wyswietlKomunikatOPrzegladzie(samochod);
            }
        }

        public static void wyswietlOkno(VKurier caller, Models.DTO.Uzytkownik.DaneUzytkownika kurier, DanePaczki[] lista)
        {
            dane = kurier;
            controller = caller;
            paczki = lista;
            samochod = null;
            Pages.loadPage("/Views/Menu/Kurier/MenuGlowneKurier.aspx");
        }

        public static void wyswietlOknoIKomunikatOPrzegladzie(VKurier caller, Models.DTO.Uzytkownik.DaneUzytkownika kurier, DanePaczki[] lista, Models.DTO.Samochod.DaneSamochodu samochodArg)
        {
            dane = kurier;
            controller = caller;
            paczki = lista;
            samochod = samochodArg;
            Pages.loadPage("/Views/Menu/Kurier/MenuGlowneKurier.aspx");
        }

        public void wyswietlKomunikatOPrzegladzie(Models.DTO.Samochod.DaneSamochodu dane)
        {
            phMessage.Visible = true;
            lMessage.Text = "Zbliża się termin kontroli pojazdu " + dane.Marka 
                + " " + dane.Model 
                + " " + dane.NumRejestracyjny
                + " - " + getProperDateString(dane.DataKontroli);
        }

        private string getProperDateString(DateTime date)
        {
            string day = date.Day > 9 ? "" + date.Day : "0" + date.Day;
            string month = date.Month > 9 ? "" + date.Month : "0" + date.Month;
            return day + "." + month + "." + date.Year;
        }

        protected void onClickDetails(object sender, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "details")
            {
                Button c = e.Item.FindControl("btDetails") as Button;
                PlaceHolder ph = e.Item.FindControl("phDetails") as PlaceHolder;
                if (c != null && ph != null)
                {
                    ph.Visible = !ph.Visible;
                }
            }
        }

        protected void onClickSendPackage(object sender, EventArgs e)
        {
        }

        protected void onClickCar(object sender, EventArgs e)
        {
        }

        protected void onClickLogout(object sender, EventArgs e)
        {
            controller.wybranoWyloguj();
        }
    }
}