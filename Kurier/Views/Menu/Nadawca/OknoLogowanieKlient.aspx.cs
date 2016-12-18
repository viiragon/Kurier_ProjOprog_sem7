using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;
using Kurier.Models.DataAccess;
using Kurier.Models.DTO.Uzytkownik;

namespace Kurier.Views.Menu
{
	public partial class LogowanieKlient : System.Web.UI.Page
	{
        private static VKlient controller;

		protected void Page_Load(object sender, EventArgs e)
		{
            Pages.setCurrent(this);
            if (controller != null)
            {
                controller.setLogowanieKlient(this);
            }
		}

        public static void wyswietlOkno(VKlient caller)
        {
            controller = caller;
            Pages.loadPage("/Views/Menu/Nadawca/OknoLogowanieKlient.aspx");
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
    protected void SignIn(object sender, EventArgs e)
    {
      new UzytkownicyModel().ZalogujJakoKlient(new DaneAuthKlienta() { Login = tbLogin.Text, Haslo = tbPassword.Text });
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

        protected void onClickBtNoLogin(object sender, EventArgs e)
        {
            controller.wybranoNadajBezLogowania();
        }
    }
}