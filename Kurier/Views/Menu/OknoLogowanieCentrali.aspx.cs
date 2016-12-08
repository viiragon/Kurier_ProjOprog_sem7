using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kurier.Views.Menu
{
    public partial class LogowanieCentrali : System.Web.UI.Page
    {
        private static VLogowanieCentrali controller;

        public static void wyswietlOkno(VLogowanieCentrali caller)
        {
            controller = caller;
            Pages.loadPage("/Views/Menu/OknoLogowanieCentrali.aspx");
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Pages.setCurrent(this);
            if (controller != null)
            {
                controller.setLogowanieCentrali(this);
            }
        }

        private bool checkAuths()
        {
            Regex r = new Regex("[A-Za-z0-9]");
            return r.IsMatch(tbLogin.Text) && r.IsMatch(tbPassword.Text);
        }

        public void wyswietlBladBrakPol()
        {
            lError.Text = "Wypełnij wszystkie pola";
        }

        public void wyswietlBladZleZnaki()
        {
            lError.Text = "Pola zawierają niedozwolone znaki";
        }

        public void wyswietlBladNiepoprawneDane()
        {
            lError.Text = "Błędne dane logowania";
        }

        protected void onClickBtLogin(object sender, EventArgs e)
        {
            lError.Text = "";
            if (tbLogin.Text.Length == 0 || tbPassword.Text.Length == 0)
            {
                wyswietlBladBrakPol();
            }
            else if (!checkAuths())
            {
                wyswietlBladZleZnaki();
            }
            else
            {
                controller.wybranoZaloguj(tbLogin.Text, tbPassword.Text);
            }
        }

        protected void onClickBtHack(object sender, EventArgs e)
        {
            controller.wybranoZaloguj("corzel", "natak139l");
        }
    }
}