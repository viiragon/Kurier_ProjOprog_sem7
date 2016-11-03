using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestAPSNET.Presenters
{
    public interface IPresenter
    {
        void setIView(Views.IView view);

        void selectedSumNumbers(int a, int b);
    }
}