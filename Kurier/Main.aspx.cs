using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestAPSNET
{
    public partial class View : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            message("START");
            new Presenters.Presenter(this);
        }

        public static void message(String message) {
            System.Diagnostics.Debug.WriteLine(message);
        }
    }
}