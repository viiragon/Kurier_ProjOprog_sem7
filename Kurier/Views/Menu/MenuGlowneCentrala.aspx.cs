using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kurier.Views.Menu
{
    public partial class MenuGlowneCentrala : System.Web.UI.Page
    {
        private static VMenuGlowne controller;

        public static void wyswietlOkno(VMenuGlowne caller)
        {
            controller = caller;
            Pages.loadPage("/Views/Menu/MenuGlowneCentrala.aspx");
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Pages.setCurrent(this);
            if (controller != null) {
                controller.setMenuGlowneCentrala(this);
            }
        }
    }
}