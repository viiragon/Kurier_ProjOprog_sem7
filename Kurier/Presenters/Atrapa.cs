using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Kurier.Interfaces.Presenter;
<<<<<<< c47f18b4a4f5a1e2d8a076586877782d3e75f0de
using Kurier.Models.DTO.Paczka;
using Kurier.Models.DTO.Uzytkownik;
=======
using Kurier.Models.DTO;
using Kurier.Models.DTO.Paczka;
>>>>>>> Dodanie widoku listy paczek i szczegółów paczek

namespace Kurier.Presenters
{
    public class Atrapa : ICMLogowanie, ICMSamochody, ICMStatystyka, ICMKurierzy, ICMPaczki, IPKurier, IPKlient
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

        private Interfaces.View.IVKurier ivKurier;
        private Interfaces.View.IVKlient ivKlient;


        public Atrapa()
        {
            logowanie = Interfaces.View.IVCentralaLogowanie.createInstance(this);
            statystyka = Interfaces.View.IVCentralaStatystyka.createInstance(this);
            paczki = Interfaces.View.IVCentralaPaczki.createInstance(this);
            samochody = Interfaces.View.IVCentralaSamochody.createInstance(this);
            kurierzy = null;// Interfaces.View.IVCentralaKurierzy.createInstance(this);

            ivKurier = Interfaces.View.IVKurier.createInstance(this);
            ivKlient = Interfaces.View.IVKlient.createInstance(this);

        }

        public void startCentrala()
        {
            logowanie.wyswietlFormularzLogowania();
        }

        public void startKurier()
        {
            ivKurier.wyswietlFormularzLogowaniaJakoKurier();
        }

        public void startNadawca()
        {
            ivKlient.wyswietlFormularzLogowaniaKlienta();
        }

        public void wybranoWylogujZCentrali()
        {
            logowanie.wyswietlFormularzLogowania();
        }

        public void wybranoZalogujDoCentrali(Models.DTO.Uzytkownik.DaneAuthUzytkownika dane)
        {
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
            DanePaczki[] listaPaczek = new Models.DTO.Paczka.DanePaczki[4];
          
            listaPaczek[0] = paczka1;
            listaPaczek[1] = paczka1;
            listaPaczek[2] = paczka2;
            listaPaczek[3] = paczka2;

            paczki.wyswietlOknoListyPaczek(listaPaczek);
        }

        public void wybranoPokazSzczegolyPaczki(int id)
        {
            if (id == 0)
            {
                paczki.wyswietlOknoSzczegolowPaczki(paczka1);
            }
            else
            {
                paczki.wyswietlOknoSzczegolowPaczki(paczka2);
            }
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


<<<<<<< c47f18b4a4f5a1e2d8a076586877782d3e75f0de

        public void wybranoLogowanieJakoKlient()
        {
            throw new NotImplementedException();
        }

        public void wybranoNadaniePaczki()
        {
            ivKlient.wyswietlFormularzNadaniaPaczki();
        }

        public void wybranoRejestracjaJakoKlient()
        {
            throw new NotImplementedException();
        }

        public void wybranoWylogujKlienta()
        {
            ivKlient.wyswietlFormularzLogowaniaKlienta();
        }

        public void wybranoZalogujMnieJakoKlient(DaneUzytkownika dane)
        {
            if (dane.Login.Equals("eadam") && dane.Haslo.Equals("natak139k"))
            {
                Models.DTO.Uzytkownik.DaneUzytkownika user = new Models.DTO.Uzytkownik.DaneUzytkownika();
                user.Imie = "Ewa";
                user.Nazwisko = "Adamska";
                user.Id = 0;
                user.Telefon = 0700880;
                user.Uprawnienia = 0;
                user.Login = dane.Login;
                user.Haslo = dane.Haslo;
                ivKlient.wyswietlMenuGlowneKlienta(user, null);
            }
            else if (dane.Login.Equals("wkruk") && dane.Haslo.Equals("natak139k"))
            {
                Models.DTO.Uzytkownik.DaneUzytkownika user = new Models.DTO.Uzytkownik.DaneUzytkownika();
                user.Imie = "Wojciech";
                user.Nazwisko = "Kruk";
                user.Id = 0;
                user.Telefon = 0700880;
                user.Uprawnienia = 0;
                user.Login = dane.Login;
                user.Haslo = dane.Haslo;
                ivKlient.wyswietlMenuGlowneKlienta(user, null);
            }
            else
            {
                ivKlient.wyswietlKomunikatOBlednychDanychLogowania();
            }
        }

        public void wybranoZapiszDaneNadanejPaczki(DanePaczki paczka)
        {
            //A PO Co?
            ivKlient.wyswietlKomunikatOPoprawnymNadaniuPaczki();
        }

        public void wybranoZarejestrujMnieJakoKlient(DaneKlienta dane)
        {
            throw new NotImplementedException();
        }

        public void wybranoNadaniePaczkiBezLogowania()
        {
            ivKlient.wyswietlFormularzNadaniaPaczkiBezLogowania();
        }



        public void wybranoPokazDateKolejnegoPrzegladu()
        {
            throw new NotImplementedException();
        }

        public void wybranoPokazListeZlecenKuriera()
        {
            throw new NotImplementedException();
        }

        public void wybranoPokazSamochodKuriera()
        {
            throw new NotImplementedException();
        }

        public void wybranoWydajPaczke(DanePaczki paczka)
        {
            throw new NotImplementedException();
        }

        public void wybranoWylogujKuriera()
        {
            throw new NotImplementedException();
        }

        public void wybranoZalogujKuriera(DaneUzytkownika dane)
        {
            throw new NotImplementedException();
        }


=======
        public static Models.DTO.Uzytkownik.DaneKuriera daneKuriera1 = new Models.DTO.Uzytkownik.DaneKuriera()
        {
            Adres = new Adres()
            {
                KodPocztowy = "09-201",
                Miasto = "Sierpc",
                NumerMieszkania = "2",
                Ulica = "Poniatowskiego"
            },
            Nazwisko = "Kowalski",
            Imie = "Maciej",
            Id = 1
        };

        public static Models.DTO.Uzytkownik.DaneKuriera daneKuriera2 = new Models.DTO.Uzytkownik.DaneKuriera()
        {
            Adres = new Adres()
            {
                KodPocztowy = "09-201",
                Miasto = "Sierpc",
                NumerMieszkania = "2",
                Ulica = "Poniatowskiego"
            },
            Nazwisko = "Kowalski",
            Imie = "Maciej",
            Id = 3
        };

        DanePaczki paczka1 = new DanePaczki()
        {
            Id = 312,
            Adres = new Adres()
            {
                KodPocztowy = "29-120",
                Miasto = "Kluczewsko",
                NumerMieszkania = "12",
                Ulica = "Spółdzielcza"
            },
            Status = new Status() { KodStatusu = 0, Kurier = daneKuriera1, Czas = new DateTime(1990, 10, 11) }
          ,
            //Historia = new List<Status>() { new Status() { KodStatusu = 0, Czas = new DateTime(2016, 12, 02) }, new Status() { KodStatusu = 1, Czas = new DateTime(2016, 12, 04) } },
            PoczatekObslugi = new DateTime(2016, 12, 02),
            KoniecObslugi = new DateTime(2016, 12, 04)
        };

        DanePaczki paczka2 = new DanePaczki()
        {
            Id = 212,
            Adres = new Adres()
            {
                Ulica = "Niebieska",
                KodPocztowy = "01-999",
                Miasto = "Białe Trzecie",
                NumerMieszkania = "139"
            }
          ,
            Status = new Status() { KodStatusu = 1, Kurier = daneKuriera2, Czas = new DateTime(1990, 10, 11) },
            PoczatekObslugi = new DateTime(1990, 10, 10),
            KoniecObslugi = new DateTime(1990, 10, 12)
        };
>>>>>>> Dodanie widoku listy paczek i szczegółów paczek
    }
}
