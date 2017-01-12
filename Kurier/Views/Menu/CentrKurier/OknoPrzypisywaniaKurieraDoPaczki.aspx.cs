using Kurier.Models.DTO.Uzytkownik;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kurier.Views.Menu
{
    public partial class OknoPrzypisywaniaKurieraDoPaczki : System.Web.UI.Page
    {
        private static VCentralaKurier controller;
        //public List<Models.DTO.Paczka.DanePaczki> paczki;
        public static DaneKuriera[] kurierzy;
        public static int idPaczki;

        protected void Page_Load(object sender, EventArgs e)
        {
            Pages.setCurrent(this);
            if (controller != null)
            {
                controller.setOknoDoPaczki(this);
            }
            if (kurierzy.Length == 0)
            {
                phLista.Visible = false;
                phNIMA.Visible = true;
            }
            else
            {
                phLista.Visible = true;
                phNIMA.Visible = false;
                if (!IsPostBack)
                {
                    rptKurierzy.DataSource = kurierzy;
                    rptKurierzy.DataBind();
                }
            }
        }

        public static void wyswietlOkno(VCentralaKurier caller, DaneKuriera[] lista, int idPaczkiArg)
        {
            controller = caller;
            kurierzy = lista;
            idPaczki = idPaczkiArg;
            Pages.loadPage("/Views/Menu/CentrKurier/OknoPrzypisywaniaKurieraDoPaczki.aspx");
        }

        protected void onClickButton(object sender, RepeaterCommandEventArgs e)
        {
            Button c;
            switch (e.CommandName)
            {
                case "details":
                    c = e.Item.FindControl("btDetails") as Button;
                    if (c != null)
                    {
                        controller.wybranoWyswietlSzczegoly(Convert.ToInt32(e.CommandArgument));
                    }
                    break;
                case "przypisz":
                    c = e.Item.FindControl("btPrzypisz") as Button;
                    if (c != null)
                    {
                        controller.wybranoPrzypisz(Convert.ToInt32(e.CommandArgument), idPaczki);
                    }
                    break;
            }
        }
    }
}