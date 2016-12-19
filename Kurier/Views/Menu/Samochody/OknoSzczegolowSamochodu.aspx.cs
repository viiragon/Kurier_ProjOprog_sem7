using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kurier.Views.Menu
{
    public partial class OknoSzczegolowSamochodu : System.Web.UI.Page
    {
        private static VCentralaSamochody controller;
        public static Models.DTO.Samochod.DaneSamochodu samochod;

        protected void Page_Load(object sender, EventArgs e)
        {
            Pages.setCurrent(this);
            if (controller != null)
            {
                controller.setOknoSzczegolowSamochodu(this);
            }
            if (!IsPostBack)
            {
                rptSamochody.DataSource = new Models.DTO.Samochod.DaneSamochodu[] { samochod };
                rptSamochody.DataBind();
            }
        }

        public static void wyswietlOkno(VCentralaSamochody caller, Models.DTO.Samochod.DaneSamochodu s)
        {
            samochod = s;
            controller = caller;
            Pages.loadPage("/Views/Menu/Samochody/OknoSzczegolowSamochodu.aspx");
        }
        protected void onClickBtCarEdit(object sender, EventArgs e)
        {
            controller.wyswietlOknoDodawaniaSamochodu();
        }
        protected void onClickBtDelete(object sender, EventArgs e)
        {

        }
    }
}