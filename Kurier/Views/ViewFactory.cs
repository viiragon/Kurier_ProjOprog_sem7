using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestAPSNET.Views
{
    public class ViewFactory
    {
        public static void initSumView(System.Web.UI.Page current, Presenters.IPresenter presenter) {
            SumView.setPresenter(presenter);
            current.Response.Redirect("/Views/SumView.aspx");
        }

        public static void initMain(System.Web.UI.Page current)
        {
            current.Response.Redirect("/Main.aspx");
        }
    }
}