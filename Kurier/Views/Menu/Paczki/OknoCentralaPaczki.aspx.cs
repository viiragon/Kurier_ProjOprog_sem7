using Kurier.Models.DTO.Paczka;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kurier.Views.Menu
{
    public partial class CentralaPaczki : System.Web.UI.Page
    {
        private static VCentralaPaczki controller;
        //public List<Models.DTO.Paczka.DanePaczki> paczki;
        public static DanePaczki[] paczki;

        protected void Page_Load(object sender, EventArgs e)
        {
            Pages.setCurrent(this);
            if (controller != null)
            {
                controller.setCentralaPaczki(this);
            }
            if (!IsPostBack)
            {
                rptPaczki.DataSource = paczki;
                rptPaczki.DataBind();
            }
        }

        public static void wyswietlOkno(VCentralaPaczki caller, DanePaczki[] lista)
        {
            controller = caller;
            paczki = lista;
            Pages.loadPage("/Views/Menu/Paczki/OknoCentralaPaczki.aspx");
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
                        controller.wybranoSzczegolyPaczki(Convert.ToInt32(e.CommandArgument));
                    }
                    break;
                case "kurier":
                    c = e.Item.FindControl("btKurier") as Button;
                    if (c != null)
                    {
                        controller.wybranoKurierPaczki(Convert.ToInt32(e.CommandArgument));
                    }
                    break;

            }
        }
    }
}