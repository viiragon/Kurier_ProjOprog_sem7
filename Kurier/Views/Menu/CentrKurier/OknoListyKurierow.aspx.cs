using Kurier.Models.DTO.Uzytkownik;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kurier.Views.Menu
{
    public partial class OknoListyKurierow : System.Web.UI.Page
    {
        private static VCentralaKurier controller;
        //public List<Models.DTO.Paczka.DanePaczki> paczki;
        public static DaneKuriera[] kurierzy;

        protected void Page_Load(object sender, EventArgs e)
        {
            Pages.setCurrent(this);
            if (controller != null)
            {
                controller.setOknoListy(this);
            }
            if (!IsPostBack)
            {
                rptKurierzy.DataSource = kurierzy;
                rptKurierzy.DataBind();
            }
        }

        public static void wyswietlOkno(VCentralaKurier caller, DaneKuriera[] lista)
        {
            controller = caller;
            kurierzy = lista;
            Pages.loadPage("/Views/Menu/CentrKurier/OknoListyKurierow.aspx");
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
            }
        }
    }
}