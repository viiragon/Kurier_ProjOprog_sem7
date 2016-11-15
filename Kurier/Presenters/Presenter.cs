using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kurier.Presenters
{
    public class Presenter : IPresenter
    {
        private Views.IView view;
        private Models.IModel model;

        public Presenter(System.Web.UI.Page main) {
            this.view = null;
            this.model = new Models.Model();
            Views.ViewFactory.initSumView(main, this);
        }

        public void setIView(Views.IView view) {
            this.view = view;
        }

        public void selectedSumNumbers(int a, int b) {
            int result = model.sumNumbers(new int[] { a, b });
     
            view.showResult(result);
        }
    }
}