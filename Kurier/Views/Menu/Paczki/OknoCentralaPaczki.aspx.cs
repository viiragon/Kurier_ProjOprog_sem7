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
            rptPaczki.DataSource = paczki;
            rptPaczki.DataBind();
        }

        public static void wyswietlOkno(VCentralaPaczki caller, DanePaczki[] lista)
        {
            controller = caller;
            paczki = lista;
            Pages.loadPage("/Views/Menu/Paczki/OknoCentralaPaczki.aspx");
        }

        protected void onClickDetails(object sender, EventArgs e)
        {
            Presenters.Atrapa.KEK_XD.wybranoPokazSzczegolyPaczki(0);
        }

        protected void onClickKurier(object sender, EventArgs e)
        {
            Presenters.Atrapa.KEK_XD.wybranoPokazSzczegolyPaczki(1);
        }
    }
}