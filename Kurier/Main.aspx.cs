using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace System
{
    public static class MyExtensions
    {
        public static string getProperDateString(this DateTime date)
        {
            string day = date.Day > 9 ? "" + date.Day : "0" + date.Day;
            string month = date.Month > 9 ? "" + date.Month : "0" + date.Month;
            return day + "." + month + "." + date.Year;
        }

        public static string ToString(this DateTime date)
        {
            return date.getProperDateString();
        }
    }
}

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

        public static void message(String message)
        {
            System.Diagnostics.Debug.WriteLine(message);
        }

        protected void onClickBtCentrala(object sender, EventArgs e)
        {
            Presenters.Atrapa.instance.startCentrala();
            //Presenters.CentralaManager.Logowanie.LogowaniePrezenter.logowaniePrezenter.startCentrala();
        }

        protected void onClickBtKurier(object sender, EventArgs e)
        {
            Presenters.Atrapa.instance.startKurier();
        }

        protected void onClickBtNadawca(object sender, EventArgs e)
        {
            Presenters.Atrapa.instance.startNadawca();
            //Presenters.KlientManager.KlientPrezenter.klientPrezenter.startNadawca();
        }
    }
}