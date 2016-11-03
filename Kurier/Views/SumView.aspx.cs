using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestAPSNET
{
    public partial class SumView : System.Web.UI.Page, Views.IView
    {
        private static Presenters.IPresenter presenter;

        public static void setPresenter(Presenters.IPresenter argPresenter) {
            presenter = argPresenter;
        }

        protected void Page_Load(object sender, EventArgs e) {
            if (presenter != null)
            {
                presenter.setIView(this);
            }
            else {
                Views.ViewFactory.initMain(this);
            }
        }

        protected void onClickBtSum(object sender, EventArgs e) {
            int a = 0;
            int b = 0;
            if (Int32.TryParse(tbElementA.Text, out a) && Int32.TryParse(tbElementB.Text, out b))
            {
                presenter.selectedSumNumbers(a, b);
            }
            else
            {
                showError();
            }
        }

        public void showResult(int result) {
            lSum.Text = result.ToString();
        }

        public void showError()
        {
            lSum.Text = "BUONT";
        }
    }
}