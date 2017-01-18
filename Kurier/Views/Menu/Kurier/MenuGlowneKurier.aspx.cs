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
        private static string komunikat;

        protected void Page_Load(object sender, EventArgs e)
        {
            Pages.setCurrent(this);
            if (controller != null)
            {
                controller.setMenuGlowneKurier(this);
            }
            if (!IsPostBack)
            {
                paczki = paczki.OrderBy(o => o.Id).ToArray();
                List<DanePaczki> nadane = new List<DanePaczki>();
                List<DanePaczki> wDrodze = new List<DanePaczki>();
                List<DanePaczki> doreczone = new List<DanePaczki>();
                foreach (DanePaczki dp in paczki)
                {
                    if (dp.Status.KodStatusu == (int)StatusEnum.Nadana)
                    {
                        nadane.Add(dp);
                    }
                    else if (dp.Status.KodStatusu == (int)StatusEnum.WDrodze)
                    {
                        wDrodze.Add(dp);
                    }
                    else
                    {
                        doreczone.Add(dp);
                    }
                }
                if (nadane.Capacity > 0)
                {
                    rptNadane.DataSource = nadane;
                    rptNadane.DataBind();
                }
                else
                {
                    phPustaNadane.Visible = true;
                    phTableNadane.Visible = false;
                }
                if (wDrodze.Capacity > 0)
                {
                    rptWDrodze.DataSource = wDrodze;
                    rptWDrodze.DataBind();
                }
                else
                {
                    phPustaWDrodze.Visible = true;
                    phTableWDrodze.Visible = false;
                }
                if (doreczone.Capacity > 0)
                {
                    rptDoreczone.DataSource = doreczone;
                    rptDoreczone.DataBind();
                }
                else
                {
                    phPustaDoreczone.Visible = true;
                    phTableDoreczone.Visible = false;
                }
                lUser.Text = dane.Imie + " " + dane.Nazwisko;
            }
            if (samochod != null)
            {
                wyswietlKomunikatOPrzegladzie(samochod);
            }
            if (komunikat != null)
            {
                lSuccess.Text = komunikat;
                phResult.Visible = true;
            }
        }

        public static void wyswietlOkno(VKurier caller, Models.DTO.Uzytkownik.DaneUzytkownika kurier, DanePaczki[] lista, string komunikatArg)
        {
            dane = kurier;
            controller = caller;
            paczki = lista;
            samochod = null;
            komunikat = komunikatArg;
            Pages.loadPage("/Views/Menu/Kurier/MenuGlowneKurier.aspx");
        }

        public static void wyswietlOknoIKomunikatOPrzegladzie(VKurier caller, Models.DTO.Uzytkownik.DaneUzytkownika kurier, DanePaczki[] lista, Models.DTO.Samochod.DaneSamochodu samochodArg, string komunikatArg)
        {
            dane = kurier;
            controller = caller;
            paczki = lista;
            samochod = samochodArg;
            komunikat = komunikatArg;
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
            Button c;
            switch (e.CommandName)
            {
                case "details":
                    c = e.Item.FindControl("btDetails") as Button;
                    PlaceHolder ph = e.Item.FindControl("phDetails") as PlaceHolder;
                    if (c != null && ph != null)
                    {
                        ph.Visible = !ph.Visible;
                    }
                    break;
                case "wydaj":
                    controller.wybranoWydaj(findPaczka(Int32.Parse(e.CommandArgument as string)));
                    break;
                case "dorecz":
                    controller.wybranoDorecz(findPaczka(Int32.Parse(e.CommandArgument as string)));
                    break;
            }
        }

        private DanePaczki findPaczka(int id)
        {
            foreach (DanePaczki dp in paczki) {
                if (dp.Id == id)
                {
                    return dp;
                }
            }
            return null;
        }

        protected void onClickCar(object sender, EventArgs e)
        {
            controller.wybranoPokazSamochod();
        }

        protected void onClickLogout(object sender, EventArgs e)
        {
            controller.wybranoWyloguj();
        }
    }
}