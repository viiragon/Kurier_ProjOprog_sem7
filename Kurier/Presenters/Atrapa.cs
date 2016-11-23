using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Kurier.Interfaces.Presenter;

namespace Kurier.Presenters
{
    public class Atrapa : ICMLogowanie, ICMSamochody, ICMStatystyka, ICMKurierzy, ICMPaczki
    {
        //TA KLASA JEST ATRAPĄ!!!! ZMIEŃCIE JĄ NA FAKTYCZNE KLASY PREZENTERÓW

        public static Atrapa LOL_TO_JA_XD = new Atrapa();
        public static ICMLogowanie LOL_TO_TEZ_JA_XD = LOL_TO_JA_XD;
        public static ICMSamochody LOL_XD = LOL_TO_JA_XD;
        public static ICMStatystyka LOL_A_TO_MOZE_NIE_JA_XD = LOL_TO_JA_XD;
        public static ICMKurierzy TOP_KEK_XD = LOL_TO_JA_XD;
        public static ICMPaczki KEK_XD = LOL_TO_JA_XD;

        private Interfaces.View.IVCentralaLogowanie logowanie;
        private Interfaces.View.IVCentralaStatystyka statystyka;
        private Interfaces.View.IVCentralaPaczki paczki;
        private Interfaces.View.IVCentralaSamochody samochody;
        private Interfaces.View.IVCentralaKurierzy kurierzy;

        public Atrapa()
        {
            logowanie = Interfaces.View.IVCentralaLogowanie.createInstance(this);
            statystyka = Interfaces.View.IVCentralaStatystyka.createInstance(this);
            paczki = null;//Interfaces.View.IVCentralaPaczki.createInstance(this);
            samochody = Interfaces.View.IVCentralaSamochody.createInstance(this);
            kurierzy = null;// Interfaces.View.IVCentralaKurierzy.createInstance(this);
        }

        public void startCentrala()
        {
            logowanie.wyswietlFormularzLogowania();
        }

        public void startKurier()
        {
            throw new NotImplementedException();
        }

        public void startNadawca()
        {
            throw new NotImplementedException();
        }

        public void wybranoWylogujZCentrali()
        {
            logowanie.wyswietlFormularzLogowania();
        }

        public void wybranoZalogujDoCentrali(Models.DTO.Uzytkownik.DaneAuthUzytkownika dane)
        {
            Random r = new Random();
            if (dane.Login.Equals("corzel") && dane.Haslo.Equals("natak139l"))
            {
                Models.DTO.Uzytkownik.DaneUzytkownika user = new Models.DTO.Uzytkownik.DaneUzytkownika();
                user.Imie = "Cichosław";
                user.Nazwisko = "Orzeł";
                user.Id = 0;
                user.Telefon = 0700880;
                user.Uprawnienia = 0;
                user.Login = dane.Login;
                user.Haslo = dane.Haslo;
                logowanie.wyswietlMenuGlowneCentrali(user, this, this, this, this);
            }
            else
            {
                logowanie.wyswietlKomunikatOBlednychDanych();
            }
        }



        public void wybranoDodajKuriera()
        {
            throw new NotImplementedException();
        }

        public void wybranoEdytujKuriera(int id)
        {
            throw new NotImplementedException();
        }

        public void wybranoPokazListeKurierow()
        {
            throw new NotImplementedException();
        }

        public void wybranoZapiszEdycjeKuriera(Models.DTO.Uzytkownik.DaneKuriera kurier)
        {
            throw new NotImplementedException();
        }

        public void wybranoZapiszNowegoKuriera(Models.DTO.Uzytkownik.DaneKuriera kurier)
        {
            throw new NotImplementedException();
        }



        public void wybranoPokazNajczestszeObszaryPaczek()
        {
            throw new NotImplementedException();
        }

        public void wybranoPokazNajczestszychKlientow()
        {
            statystyka.wyswietlOknoNajczestszychKlientow(null);
        }

        public void wybranoPokazObciazenieKurierow()
        {
            throw new NotImplementedException();
        }

        public void wybranoPokazStatystykiPaczek()
        {
            throw new NotImplementedException();
        }



        public void wybranoAktualizujSzczegolySamochodu(int id)
        {
            throw new NotImplementedException();
        }

        public void wybranoDodajSamochod()
        {
            throw new NotImplementedException();
        }

        public void wybranoOtworzFormularzZleceniaDoSerwisu(int id)
        {
            throw new NotImplementedException();
        }

        public void wybranoPokazListeSamochodow()
        {
            samochody.wyswietlOknoListySamochodow(null);
        }

        public void wybranoPokazSzczegolySamochodu(int id)
        {
            throw new NotImplementedException();
        }

        public void wybranoPrzypiszKurieraDoSamochodu(int idSamochodu)
        {
            throw new NotImplementedException();
        }

        public void wybranoUsunSamochod(int id)
        {
            throw new NotImplementedException();
        }

        public void wybranoWyslijZlecenieDoSerwisu()
        {
            throw new NotImplementedException();
        }

        public void wybranoZapiszNowySamochod(Models.DTO.Samochod.DaneSamochodu dane)
        {
            throw new NotImplementedException();
        }

        public void wybranoZapiszPowiazanieKurieraZSamochodem(int idKuriera)
        {
            throw new NotImplementedException();
        }



        public void wybranoEdytujStatusPaczki(int id)
        {
            throw new NotImplementedException();
        }

        public void wybranoPokazListePaczek()
        {
            throw new NotImplementedException();
        }

        public void wybranoPokazSzczegolyPaczki(int id)
        {
            throw new NotImplementedException();
        }

        public void wybranoPrzypiszKurieraDoPaczki(int idPaczki)
        {
            throw new NotImplementedException();
        }

        public void wybranoZapiszPowiazanieKurieraZPaczka(int idKuriera)
        {
            throw new NotImplementedException();
        }

        public void wybranoZapiszStatusPaczki(Models.DTO.Paczka.Status status)
        {
            throw new NotImplementedException();
        }
    }
}
