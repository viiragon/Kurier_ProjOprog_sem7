using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Kurier.Interfaces.Presenter;
using Kurier.Models.DTO.Samochod;
using Kurier.Models.DataAccess;
using Kurier.Models.DTO.Uzytkownik;
using System.Net.Mail;
using System.Net;

namespace Kurier.Presenters.CentralaManager.SamochodyCM
{

    public class SamochodyPrezenter : ICMSamochody
    { 

        private Interfaces.View.IVCentralaSamochody samochody;
        private SamochodyModel samochodyModel;
        private KurierzyModel kurierzyModel;
        public SamochodyPrezenter()
        {
            samochody = Interfaces.View.IVCentralaSamochody.createInstance(this);
            samochodyModel = new SamochodyModel();
            kurierzyModel = new KurierzyModel();
        }
        
        public void wybranoAktualizujSzczegolySamochodu(int id)
        {
            DaneSamochodu samochod = samochodyModel.PobierzSamochod(id);
            samochody.aktualizujOknoSzczegolowSamochodu(samochod);
        }

        public void wybranoDodajSamochod()
        {
            samochody.wyswietlOknoDodawaniaSamochodu();
        }

        public void wybranoOtworzFormularzZleceniaDoSerwisu(int id)
        {
            DaneSamochodu samochod = samochodyModel.PobierzSamochod(id);
            samochody.wyswietlOknoWysylaniaZleceniaDoSerwisu(samochod);
        }

        public void wybranoPokazListeSamochodow()
        {
            DaneSamochodu[] listaSamochodow = samochodyModel.PobierzListeSamochodow().ToArray();
            samochody.wyswietlOknoListySamochodow(listaSamochodow, null);
        }

        public void wybranoPokazSzczegolySamochodu(int id)
        {
            DaneSamochodu samochod = samochodyModel.PobierzSamochod(id);
            DaneKuriera kurier = kurierzyModel.PobierzKurieraSamochodu(samochodyModel, id);
            samochody.wyswietlOknoSzczegolowSamochodu(samochod, kurier);
        }

        public void wybranoPrzypiszKurieraDoSamochodu(int idSamochodu)
        {
            DaneKuriera [] listakurierow = kurierzyModel.PobierzListeKurierow().ToArray();
            samochody.wyswietlOknoPrzypisaniaSamochoduDoKuriera(idSamochodu, listakurierow);
        }

        public void wybranoUsunSamochod(int id)
        {
            samochodyModel.UsunSamochod(id);
            wybranoPokazListeSamochodow();
        }

        public void wybranoWyslijZlecenieDoSerwisu(Models.DTO.Samochod.DaneSamochodu dane)
        {
            var client = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential("kuriercentrala@gmail.com", "centrala123a"), EnableSsl = true
            };
            client.Send("kuriercentrala@gmail.com", "testowacentrala@gmail.com", "Zlecenie do serwisu", dane.ToString());
           // Console.WriteLine("Send");
           /* MailMessage zlecenie = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            zlecenie.From = new MailAddress("kuriercentrala@gmail.com"); //kuriercentrala centrala123a testowacentrala testowa123a
            zlecenie.To.Add("testowacentrala@gmail.com");
            zlecenie.Subject = "Zlecenie do serwisu";
            zlecenie.Body = dane.ToString();
           // zlecenie.Body = "Tu będzie tekst";

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("kuriercentrala", "centrala123a");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(zlecenie);*/


            /*do pliku lokalnego?*/
            System.IO.StreamWriter file = new System.IO.StreamWriter("C:\\text.txt");
            file.WriteLine(dane.ToString());
            file.Close();

           // samochody.wyswietlOknoWysylaniaZleceniaDoSerwisu(null);
        }

        public void wybranoZapiszNowySamochod(DaneSamochodu dane)
        {
            bool czyPoprawneDane = samochodyModel.WalidujDaneSamochodu(dane);
            if (czyPoprawneDane)
            {
                samochodyModel.DodajSamochod(dane);
            }
            wybranoPokazListeSamochodow();
        }

        public void wybranoZapiszPowiazanieKurieraZSamochodem(int idSamochodu, int idKuriera)
        {
            DaneSamochodu dSamochod = samochodyModel.PobierzSamochod(idSamochodu);
            DaneKuriera dKuriera = kurierzyModel.PobierzKuriera(idKuriera);

            bool poprawneDaneSamochod = samochodyModel.WalidujDaneSamochodu(dSamochod);
            bool poprawneDaneKurier = kurierzyModel.WalidujDaneKuriera(dKuriera);
            if (poprawneDaneSamochod && poprawneDaneKurier)
            {
                samochodyModel.PowiazKurieraISamochod(idSamochodu, idKuriera);
                dSamochod = samochodyModel.PobierzSamochod(idSamochodu);
                dKuriera = kurierzyModel.PobierzKuriera(idKuriera);
                if (idKuriera == -1)
                {
                    samochody.wyswietlOknoSzczegolowSamochoduZKomunikatem(dSamochod, "Usunięto przypisanie", null);
                }
                else
                {
                    samochody.wyswietlOknoSzczegolowSamochoduZKomunikatem(dSamochod, "Przypisano kuriera", dKuriera);
                }
            }
            else
            {
                //INWIGILACJA >:D
                dSamochod = samochodyModel.PobierzSamochod(idSamochodu);
                dKuriera = kurierzyModel.PobierzKuriera(idKuriera);
                samochody.wyswietlOknoSzczegolowSamochoduZKomunikatem(dSamochod, "Błąd", dKuriera);
            }
            //throw new NotImplementedException();    
        }
    }
}