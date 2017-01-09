using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kurier.Views.Menu
{
    public partial class OknoListySamochodow : System.Web.UI.Page
    {
        private static VCentralaSamochody controller;
        public static Models.DTO.Samochod.DaneSamochodu[] samochody;
        public static string komentarz;

        protected void Page_Load(object sender, EventArgs e)
        {
            Pages.setCurrent(this);
            if (controller != null)
            {
                controller.setOknoListySamochodow(this);
            }
            if (!IsPostBack)
            {
                rptSamochody.DataSource = samochody;
                rptSamochody.DataBind();
            }
            if (komentarz != null)
            {
                phMessage.Visible = true;
                lMessage.Text = komentarz;
            }        
        }

        public static void wyswietlOkno(VCentralaSamochody caller, Models.DTO.Samochod.DaneSamochodu[] lista, string komentarzArg)
        {
            samochody = lista;
            komentarz = komentarzArg;
            controller = caller;
            Pages.loadPage("/Views/Menu/Samochody/OknoListySamochodow.aspx");
        }

        protected void onClickBtCarEdit(object sender, EventArgs e)
        {
            controller.wyswietlOknoDodawaniaSamochodu();
        }
        protected void onClickDetails(object sender, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "details")
            {
                Button c = e.Item.FindControl("btDetails") as Button;
                int id = Convert.ToInt32(e.CommandArgument);
                controller.wybranoPokazSzczegoly(id);
            }
            else if (e.CommandName == "delete")
            {
                int id = Convert.ToInt32(e.CommandArgument);
                controller.wybranoUsunSamochod(id);
            }
        }
      
        protected void onClickBtAddCar(object sender, EventArgs e)
        {
            controller.wyswietlOknoDodawaniaSamochodu();
        }
        protected void onClickBtDelete(object sender, EventArgs e)
        {

        }

        private Models.DTO.Samochod.DaneSamochodu getDaneSamochodu(int id)
        {
            foreach(Models.DTO.Samochod.DaneSamochodu s in samochody)
            {
                if (s.Id == id)
                {
                    return s;
                }
            }
            return samochody[0];
        }
    }
}