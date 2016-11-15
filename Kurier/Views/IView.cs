using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kurier.Views
{
    public interface IView
    {
        void showResult(int result);

        void showError();
    }
}