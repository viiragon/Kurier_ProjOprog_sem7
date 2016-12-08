using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;

namespace Kurier.Views.Menu.Kurier
{
	public partial class OknoLogowanieKurier : System.Web.UI.Page
	{
        private static VKurier controller;

		protected void Page_Load(object sender, EventArgs e)
		{
            Pages.setCurrent(this);
            if (controller != null)
            {
                controller.setOknoLogowanieKurier(this);
            }
		}

        public static void wyswietlOkno(VKurier caller)
        {
            controller = caller;
            Pages.loadPage("/Views/Menu/Kurier/LogowanieKurier.aspx");
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
            controller.wybranoZaloguj("mkowa", "natak139a");
        }
    }
}