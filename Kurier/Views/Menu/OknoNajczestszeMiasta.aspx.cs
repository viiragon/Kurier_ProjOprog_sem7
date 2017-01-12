using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kurier.Views.Menu
{
    public partial class OknoNajczestszeMiasta : System.Web.UI.Page
    {

        private static VCentralaStatystyka controller;
        public static Models.DTO.Statystyka.StatystykaObszaru.DaneObszaru[] miasta;

        public static void wyswietlOkno(VCentralaStatystyka caller, Models.DTO.Statystyka.StatystykaObszaru.DaneObszaru[] lista)
        {
            miasta = lista;
            controller = caller;
            Pages.loadPage("/Views/Menu/OknoNajczestszeMiasta.aspx");
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Pages.setCurrent(this);
            if (controller != null)
            {
                controller.setNajczestszeMiasta(this);
            }
            if (!IsPostBack)
            {
                rptMiasta.DataSource = miasta;
                rptMiasta.DataBind();
            }
        }
    }
}