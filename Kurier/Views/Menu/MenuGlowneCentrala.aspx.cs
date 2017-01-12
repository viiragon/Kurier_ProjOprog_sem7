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
        private static Models.DTO.Uzytkownik.DaneUzytkownika dane;

        public static void wyswietlOkno(VMenuGlowne caller, Models.DTO.Uzytkownik.DaneUzytkownika daneArg)
        {
            controller = caller;
            dane = daneArg;
            Pages.loadPage("/Views/Menu/MenuGlowneCentrala.aspx");
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Pages.setCurrent(this);
            if (controller != null) {
                controller.setMenuGlowneCentrala(this);
            }
            if (dane != null)
            {
                lUser.Text = dane.Imie + " " + dane.Nazwisko;
            }
        }

        protected void onClickBtWyloguj(object sender, EventArgs e)
        {
            controller.wybranoWyloguj();
        }
        protected void onClickBtListaKurierow(object sender, EventArgs e)
        {
            controller.wybranoPokazListeKurierow();
        }
        protected void onClickBtListaPaczek(object sender, EventArgs e)
        {
            controller.wybranoPokazListePaczek();
        }
        protected void onClickBtListaSamochodow(object sender, EventArgs e)
        {
            controller.wybranoPokazListeSamochodow();
        }
        protected void onClickBtNajczestsiKlienci(object sender, EventArgs e)
        {
            controller.wybranoPokazNajczeszychKlientow();
        }
        protected void onClickBtNajczestszeMiasta(object sender, EventArgs e)
        {
            controller.wybranoPokazNajczestszeMiasta();
        }
       
    }
}