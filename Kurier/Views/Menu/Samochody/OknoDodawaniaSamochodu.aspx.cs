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
    public partial class OknoDodawaniaSamochodu : System.Web.UI.Page
    {
        private static VCentralaSamochody controller;

        protected void Page_Load(object sender, EventArgs e)
        {
            Pages.setCurrent(this);
            if (controller != null)
            {
                controller.setCentralaSamochody(this);
            }

        }

        public static void wyswietlOkno(VCentralaSamochody caller)
        {
            controller = caller;
            Pages.loadPage("/Views/Menu/Samochody/OknoDodawaniaSamochodu.aspx");
        }

        private bool walidujDane()
        {
            bool jestOk = true;
            lError.Text = "";

            if (String.IsNullOrEmpty(tbKurier.Text))
            {
                jestOk = false;
                lError.Text += "-Brak kuriera ";
            }
            DateTime tmpData = new DateTime();
            DateTime.TryParseExact(tbDataKont.Text, "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out tmpData);
            bool dataOk = DateTime.Now < tmpData;
            if (String.IsNullOrEmpty(tbDataKont.Text) || !dataOk)
            {
                jestOk = false;
                lError.Text += "-Niepoprawna data kontroli ";
            }
            if (String.IsNullOrEmpty(tbMarka.Text))
            {
                jestOk = false;
                lError.Text += "-Brak marki ";
            }
            if (String.IsNullOrEmpty(tbModel.Text))
            {
                jestOk = false;
                lError.Text += "-Brak modelu ";
            }
            bool numOk = Regex.IsMatch(tbNumRej.Text, "^[A-Z][A-Z][ ][0-9A-Z]{5}");
            if (String.IsNullOrEmpty(tbNumRej.Text) || !numOk)
            {
                jestOk = false;
                lError.Text += "-Niepoprawna nr rejestracyjny ";
            }
            if (String.IsNullOrEmpty(tbStan.Text))
            {
                jestOk = false;
                lError.Text += "-Brak stanu ";
            }

            return jestOk;
        }

        protected void onClickSave(object sender, EventArgs e)
        {
            if (walidujDane())
            {
                DateTime tmpData = new DateTime();
                DateTime.TryParseExact(tbDataKont.Text, "dd.MM.yyyy", null, System.Globalization.DateTimeStyles.None, out tmpData);
                DaneSamochodu samochod = new DaneSamochodu
                {
                    Marka = tbMarka.Text,
                    Model = tbModel.Text,
                    NumRejestracyjny = tbNumRej.Text,
                    Stan = tbStan.Text,
                    DataKontroli = tmpData
                };
                controller.wybranoDodajSamochod(samochod);
            }
        }
    }
}