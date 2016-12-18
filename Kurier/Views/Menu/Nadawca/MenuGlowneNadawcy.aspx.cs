using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kurier.Views.Menu
{
    public partial class MenuGlowneNadawcy : System.Web.UI.Page
    {
        private static VKlient controller;
        private static Models.DTO.Uzytkownik.DaneUzytkownika dane;

        public static void wyswietlOkno(VKlient caller, Models.DTO.Uzytkownik.DaneUzytkownika daneArg)
        {
            controller = caller;
            dane = daneArg;
            Pages.loadPage("/Views/Menu/Nadawca/MenuGlowneNadawcy.aspx");
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Pages.setCurrent(this);
            if (controller != null) {
                controller.setMenuGlowne(this);
            }
            if (dane != null)
            {
                lUser.Text = dane.Imie + " " + dane.Nazwisko;
            }
        }

        protected void onClickBtNadaj(object sender, EventArgs e)
        {
            controller.wybranoNadaj();
        }

        protected void onClickBtWyloguj(object sender, EventArgs e)
        {
            controller.wybranoWyloguj();
        }
    }
}