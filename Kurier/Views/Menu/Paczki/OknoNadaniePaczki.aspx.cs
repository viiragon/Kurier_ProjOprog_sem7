using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kurier.Views.Menu
{
    public partial class NadaniePaczki : System.Web.UI.Page
    {
        private static VKlient controller;
        private static bool zalogowany = true;


        public static void wyswietlOkno(VKlient caller, bool zalogowanyArg)
        {
            controller = caller;
            zalogowany = zalogowanyArg;
            Pages.loadPage("/Views/Menu/Paczki/OknoNadaniePaczki.aspx");
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Pages.setCurrent(this);
            if (controller != null)
            {
                controller.setNadawaniePaczki(this);
            }
        }

        private bool checkAuths()
        {
            //Regex r = new Regex("[A-Za-z0-9.,]");
            return true;//r.IsMatch(tbLogin.Text) && r.IsMatch(tbPassword.Text);
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

        public void wyswietlKomunikatONadaniuPaczki()
        {
            lError.Text = "Paczka nadana poprawnie";
        }

        protected void onClickBtNadaj(object sender, EventArgs e)
        {
            if (tbAdresat.Text.Length == 0 || tbAdresAdresata.Text.Length == 0 || tbNadawca.Text.Length == 0 || tbAdresNadawcy.Text.Length == 0)
            {
                wyswietlBladBrakPol();
            }
            else if (!checkAuths())
            {

            }
            else
            {
                controller.wybranoZapiszNadanaPaczke(tbAdresat.Text, tbAdresAdresata.Text, tbNadawca.Text, tbAdresNadawcy.Text);
            }
        }
    }
}