using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kurier.Views.Menu
{
    public partial class NajczestsiKlienci : System.Web.UI.Page
    {
        private static VCentralaStatystyka controller;
        public static Models.DTO.Statystyka.StatystykaKlientow.DaneStatystykiKlienta[] klienci;

        public static void wyswietlOkno(VCentralaStatystyka caller, Models.DTO.Statystyka.StatystykaKlientow.DaneStatystykiKlienta[] lista)
        {
            klienci = lista;
            controller = caller;
            Pages.loadPage("/Views/Menu/OknoNajczestsiKlienci.aspx");
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Pages.setCurrent(this);
            if (controller != null)
            {
                controller.setNajczestsiKlienci(this);
            }
            if (!IsPostBack)
            {
                rptKlienci.DataSource = klienci;
                rptKlienci.DataBind();
            }
        }
    }
}