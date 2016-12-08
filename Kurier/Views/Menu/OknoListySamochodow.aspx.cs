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

        protected void Page_Load(object sender, EventArgs e)
        {
            Pages.setCurrent(this);
            if (controller != null)
            {
                controller.setOknoListySamochodow(this);
            }
        }

        public static void wyswietlOkno(VCentralaSamochody caller)
        {
            controller = caller;
            Pages.loadPage("/Views/Menu/OknoListySamochodow.aspx");
        }

        protected void onClickBtCarEdit(object sender, EventArgs e)
        {
            controller.wyswietlOknoDodawaniaSamochodu();
        }
        protected void onClickBtCarDetails(object sender, EventArgs e)
        {
            controller.wyswietlOknoSzczegolowSamochodu(null);
        }
        protected void onClickBtAddCar(object sender, EventArgs e)
        {
            controller.wyswietlOknoDodawaniaSamochodu();
        }
        protected void onClickBtDelete(object sender, EventArgs e)
        {

        }
    }
}