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
            lMessage.Text = "Zbliża się termin kontroli pojazdu Peugeot Boxer " + dane.NumRejestracyjny + " - 15.03.2017";
        }

        protected void onClickDetails(object sender, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "details")
            {
                Button c = e.Item.FindControl("btDetails") as Button;
                if (c != null)
                {
                    MainLauncher.message(c.Attributes["data-id"]);
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