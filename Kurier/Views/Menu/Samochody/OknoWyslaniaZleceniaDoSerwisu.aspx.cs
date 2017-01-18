using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Kurier.Models.DTO.Samochod;
using System.Text.RegularExpressions;

namespace Kurier.Views.Menu
{
    public partial class OknoWyslaniaZleceniaDoSerwisu : System.Web.UI.Page
    {
        private static VCentralaSamochody controller;
        public static Models.DTO.Samochod.DaneSamochodu samochod;

        protected void Page_Load(object sender, EventArgs e)
        {
            Pages.setCurrent(this);
            if (controller != null)
            {
                controller.setOknoWyslaniaZleceniaDoSerwisu(this);
            }

        }

        public static void wyswietlOkno(VCentralaSamochody caller, Models.DTO.Samochod.DaneSamochodu s)
        {
            samochod = s;
            controller = caller;
            Pages.loadPage("/Views/Menu/Samochody/OknoWyslaniaZleceniaDoSerwisu.aspx");
        }

        private bool walidujDane()
        {
            if (String.IsNullOrEmpty(tbInfo.Value))
            {
                lSuccess.Text = "";
                lError.Text = "Błąd: Informacja dla serwisu nie może być pusta!";
                return false;
            }
            if (tbInfo.Value.Length > 500)
            {
                lSuccess.Text = "";
                lError.Text = "Błąd: Informacja dla serwisu nie może mieć więcej niż 500 znaków!";
                return false;
            }
            return true;
        }

        protected void onClickBtSend(object sender, EventArgs e)
        {
            if (walidujDane())
            {
                //wybranoWyslijZlecenieDoSerwisu();
                lError.Text = "";
                lSuccess.Text = "Sukces: Zlecenie zostało wysłane.";
            }
        }
    }
}