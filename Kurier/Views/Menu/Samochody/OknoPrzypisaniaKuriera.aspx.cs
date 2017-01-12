using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kurier.Views.Menu.Samochody
{
    public partial class OknoPrzypisaniaKuriera : System.Web.UI.Page
    {
        private static VCentralaSamochody controller;
        public static Models.DTO.Uzytkownik.DaneKuriera[] kurierzy;
        public static string komentarz;
        private static int id_samochodu;

        protected void Page_Load(object sender, EventArgs e)
        {
            Pages.setCurrent(this);
            if (controller != null)
            {
                controller.setOknoPrzypisaniaKuriera(this);
            }
            if (!IsPostBack)
            {
                rptKurierzy.DataSource = kurierzy;
                rptKurierzy.DataBind();
            }
          
        }

        public static void wyswietlOkno(VCentralaSamochody caller, int idSamochodu, Models.DTO.Uzytkownik.DaneKuriera[] lista)
        {
            id_samochodu = idSamochodu;
            kurierzy = lista;
            controller = caller;
            Pages.loadPage("/Views/Menu/Samochody/OknoPrzypisaniaKuriera.aspx");
        }

       
        protected void onClickPrzypisz(object sender, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "przypisz")
            {
                Button c = e.Item.FindControl("btPrzypisz") as Button;
                int id_kuriera = Convert.ToInt32(e.CommandArgument);
                controller.wybranoPowiazKurieraZSamochodu(id_samochodu, id_kuriera);
            }
        }

        protected void onClickBrakPrzypisania(object sender, EventArgs e)
        {
            controller.wybranoPowiazKurieraZSamochodu(id_samochodu, -1);
        }
    }
}