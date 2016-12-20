using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kurier.Views.Menu.Samochody
{
    public partial class OknoPrzypisaniaSamochodu : System.Web.UI.Page
    {
        private static VCentralaSamochody controller;
        private static Models.DTO.Uzytkownik.DaneKuriera[] dane;
        private static int idSamochodu;
        
        public static void wyswietlOkno(VCentralaSamochody caller, int idSamochoduArg, Models.DTO.Uzytkownik.DaneKuriera[] kurierzy)
        {
            dane = kurierzy;
            idSamochodu = idSamochoduArg;
            controller = caller;
            Pages.loadPage("/Views/Menu/Samochody/OknoPrzypisaniaSamochodu.aspx");
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Pages.setCurrent(this);
            if (controller != null)
            {
                controller.setOknoPrzypisaniaSamochodu(this);
            }
            if (!IsPostBack)
            {
                rptKurierzy.DataSource = dane;
                rptKurierzy.DataBind();
            }
        }
        
        protected void onClickBind(object sender, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "bind")
            {
                Button c = e.Item.FindControl("btBind") as Button;
                if (c != null)
                {
                    int id = Int32.Parse(c.Attributes["data-id"] as string);
                    controller.wybranoPowiazKurieraZSamochodu(idSamochodu, id);
                }
            }
        }
    }
}