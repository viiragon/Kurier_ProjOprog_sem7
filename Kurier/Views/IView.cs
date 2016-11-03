using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestAPSNET.Views
{
    public interface IView
    {
        void showResult(int result);

        void showError();
    }
}