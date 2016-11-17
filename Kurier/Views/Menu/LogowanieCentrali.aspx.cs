using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kurier.Views.Menu
{
    public partial class LogowanieCentrali : System.Web.UI.Page
    {
        private static VLogowanieCentrali controller;

        public static void wyswietlOkno(VLogowanieCentrali caller) {
            controller = caller;
            Pages.loadPage("/Views/Menu/LogowanieCentrali.aspx");
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Pages.setCurrent(this);
            if (controller != null) {
                controller.setLogowanieCentrali(this);
            }
        }

        protected void onClickBtLogin(object sender, EventArgs e)
        {
        }
    }
}