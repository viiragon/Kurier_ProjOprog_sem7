﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kurier.Views.Menu
{
    public partial class OknoEdycjiSamochodu : System.Web.UI.Page
    {
        private static VCentralaSamochody controller;

        protected void Page_Load(object sender, EventArgs e)
        {
            Pages.setCurrent(this);
            if (controller != null)
            {
                controller.setOknoEdycjiSamochodu(this);
            }
        }

        public static void wyswietlOkno(VCentralaSamochody caller)
        {
            controller = caller;
            Pages.loadPage("/Views/Menu/Samochody/OknoEdycjiSamochodu.aspx");
        }

        protected void onClickSave(object sender, EventArgs e)
        {

        }
    }
}