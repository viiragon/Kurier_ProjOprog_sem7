using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kurier
{
    public class Pages
    {
        private static System.Web.UI.Page current;

        public static void setCurrent(System.Web.UI.Page newCurrent)
        {
            current = newCurrent;
        }

        public static void loadPage(String url)
        {
            current.Response.Redirect(url);
        }
    }

    public partial class MainLauncher : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Pages.setCurrent(this);
            message("START");
            //new Presenters.Presenter(this);
        }

        public static void message(String message) {
            System.Diagnostics.Debug.WriteLine(message);
        }

        protected void onClickBtCentrala(object sender, EventArgs e)
        {
            Presenters.Atrapa.LOL_TO_JA_XD.startCentrala();
        }

        protected void onClickBtKurier(object sender, EventArgs e)
        {
            Presenters.Atrapa.LOL_TO_JA_XD.startKurier();
        }

        protected void onClickBtNadawca(object sender, EventArgs e)
        {
            Presenters.Atrapa.LOL_TO_JA_XD.startNadawca();
        }
    }
}