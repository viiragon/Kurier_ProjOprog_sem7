using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Kurier.Interfaces.Presenter;
using Kurier.Models.DTO.Paczka;
using Kurier.Models.DTO.Uzytkownik;
using Kurier.Models.DTO.Statystyka;
using Kurier.Models.DTO.Samochod;
using Kurier.Models.DTO;
using Kurier.Models.DTO.Paczka;

namespace Kurier.Presenters
{
    public class Atrapa : ICMLogowanie, ICMSamochody, ICMStatystyka, ICMKurierzy, ICMPaczki, IPKurier, IPKlient
    {
        //TA KLASA JEST ATRAPĄ!!!! ZMIEŃCIE JĄ NA FAKTYCZNE KLASY PREZENTERÓW

        public static Atrapa LOL_TO_JA_XD = new Atrapa();
        public static ICMLogowanie LOL_TO_TEZ_JA_XD;
        public static ICMSamochody PCentrSamochody;//new Presenters.CentralaManager.SamochodyCM.SamochodyPrezenter();
        public static ICMStatystyka LOL_A_TO_MOZE_NIE_JA_XD;
        public static ICMKurierzy TOP_KEK_XD;
        public static ICMPaczki KEK_XD;

        private Interfaces.View.IVCentralaLogowanie logowanie;
        private Interfaces.View.IVCentralaStatystyka statystyka;
        private Interfaces.View.IVCentralaPaczki paczki;
        private Interfaces.View.IVCentralaSamochody samochody;
        private Interfaces.View.IVCentralaKurierzy kurierzy;

        private Interfaces.View.IVKurier ivKurier;
        private Interfaces.View.IVKlient ivKlient;


        public Atrapa()
        {
            LOL_TO_TEZ_JA_XD = this;
            LOL_A_TO_MOZE_NIE_JA_XD = this;
            PCentrSamochody = this;
            TOP_KEK_XD = this;
            KEK_XD = this;
            logowanie = Interfaces.View.IVCentralaLogowanie.createInstance(LOL_TO_TEZ_JA_XD);
            statystyka = Interfaces.View.IVCentralaStatystyka.createInstance(LOL_A_TO_MOZE_NIE_JA_XD);
            paczki = Interfaces.View.IVCentralaPaczki.createInstance(KEK_XD);
            samochody = Interfaces.View.IVCentralaSamochody.createInstance(PCentrSamochody);
            kurierzy = null;// Interfaces.View.IVCentralaKurierzy.createInstance(this);

            ivKurier = Interfaces.View.IVKurier.createInstance(this);
            ivKlient = Interfaces.View.IVKlient.createInstance(this);
            samochod1.Kurier = daneKuriera1;
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
                user.UserId = 0;
                user.Telefon = 0700880;
                user.Uprawnienia = 0;
                user.Login = dane.Login;
                user.Haslo = dane.Haslo;
                logowanie.wyswietlMenuGlowneCentrali(user, this, PCentrSamochody, this, this);
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
            samochody.wyswietlOknoListySamochodow(new Models.DTO.Samochod.DaneSamochodu[] { samochod1, samochod2 });
        }

        public void wybranoPokazSzczegolySamochodu(int id)
        {
            GUPIEDaneSamochodu retSamochod = id == samochod1.Id ? samochod1 : samochod2;
            MainLauncher.message((retSamochod.Kurier == null) + "");
            samochody.wyswietlOknoSzczegolowSamochodu(retSamochod, retSamochod.Kurier);
        }

        public void wybranoPrzypiszKurieraDoSamochodu(int idSamochodu)
        {
            samochody.wyswietlOknoPrzypisaniaSamochoduDoKuriera(idSamochodu, new DaneKuriera[] { daneKuriera1, daneKuriera2 });
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

        public void wybranoZapiszPowiazanieKurieraZSamochodem(int idSamochodu, int idKuriera)
        {
            DaneKuriera kurier = idKuriera == daneKuriera1.UserId ? daneKuriera1 : daneKuriera2;
            GUPIEDaneSamochodu samochod = idSamochodu == samochod1.Id ? samochod1 : samochod2;
            kurier.Samochod = samochod;
            samochod.Kurier = kurier;
            samochody.wyswietlOknoSzczegolowSamochoduZKomunikatem(samochod, "Przypisano kuriera", kurier);
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

        public void wybranoZapiszPowiazanieKurieraZPaczka(int idKuriera, int idPaczki)
        {
            throw new NotImplementedException();
        }

        public void wybranoZapiszStatusPaczki(Models.DTO.Paczka.Status status, int idPaczki)
        {
            throw new NotImplementedException();
        }

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
                Models.DTO.Uzytkownik.DaneUzytkownika user = new Models.DTO.Uzytkownik.DaneUzytkownika
                {
                    Imie = "Ewa",
                    Nazwisko = "Adamska",
                    UserId = 0,
                    Telefon = 0700880,
                    Uprawnienia = 0,
                    Login = dane.Login,
                    Haslo = dane.Haslo
                };
                ivKlient.wyswietlMenuGlowneKlienta(user, null);
            }
            else if (dane.Login.Equals("wkruk") && dane.Haslo.Equals("natak139k"))
            {
                Models.DTO.Uzytkownik.DaneUzytkownika user = new Models.DTO.Uzytkownik.DaneUzytkownika
                {
                    Imie = "Wojciech",
                    Nazwisko = "Kruk",
                    UserId = 0,
                    Telefon = 0700880,
                    Uprawnienia = 0,
                    Login = dane.Login,
                    Haslo = dane.Haslo
                };
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
            ivKurier.wyswietlFormularzLogowaniaJakoKurier();
        }

        public void wybranoZalogujKuriera(DaneUzytkownika dane)
        {
            if (dane.Login.Equals("mkowa") && dane.Haslo.Equals("natak139a"))
            {
                Models.DTO.Uzytkownik.DaneUzytkownika user = daneKuriera1;
                user.Login = dane.Login;
                user.Haslo = dane.Haslo;
                //ivKurier.wyswietlOknoListyZlecenKuriera(user, new Models.DTO.Paczka.DanePaczki[] { paczka1, paczka2 });
                ivKurier.wyswietlOknoListyZlecenKurieraZKomunikatemOPrzegladzie(user, new Models.DTO.Paczka.DanePaczki[] { paczka1, paczka2 }, samochod1);
            }
        }

        public void wybranoPokazSzczegolyPaczkiDlaKuriera(int id)
        {
            throw new NotImplementedException();
        }

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
            UserId = 1
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
            Nazwisko = "Nowakowski",
            Imie = "Krystian",
            UserId = 2
        };

        DanePaczki paczka1 = new DanePaczki()
        {
            Id = 312,
            AdresAdresata = new Adres()
            {
                KodPocztowy = "29-120",
                Miasto = "Kluczewsko",
                NumerMieszkania = "12",
                Ulica = "Spółdzielcza"
            },
            Nadawca = new DaneUzytkownika()
            {
                Imie = "Jan",
                Nazwisko = "Kowalski",
                Adres = new Adres()
                {
                    Ulica = "Biała",
                    KodPocztowy = "11-008",
                    Miasto = "Kielce",
                    NumerMieszkania = "139"
                },
            },
            Adresat = new DaneUzytkownika()
            {
                Imie = "Maria",
                Nazwisko = "Janda",
                Adres = new Adres()
                {
                    Ulica = "Niebieska",
                    KodPocztowy = "01-999",
                    Miasto = "Białe Trzecie",
                    NumerMieszkania = "139"
                },
            },
            Status = new Status() { KodStatusu = 0, Kurier = daneKuriera1, Czas = new DateTime(1990, 10, 11) },
            //Historia = new List<Status>() { new Status() { KodStatusu = 0, Czas = new DateTime(2016, 12, 02) }, new Status() { KodStatusu = 1, Czas = new DateTime(2016, 12, 04) } },
            PoczatekObslugi = new DateTime(2016, 12, 02),
            KoniecObslugi = new DateTime(2016, 12, 04)
        };

        DanePaczki paczka2 = new DanePaczki()
        {
            Id = 212,
            AdresAdresata = new Adres()
            {
                Ulica = "Niebieska",
                KodPocztowy = "01-999",
                Miasto = "Białe Trzecie",
                NumerMieszkania = "139"
            },
            Nadawca = new DaneUzytkownika()
            {
                Imie = "Jan",
                Nazwisko = "Kowalski",
                Adres = new Adres()
                {
                    Ulica = "Biała",
                    KodPocztowy = "11-008",
                    Miasto = "Kielce",
                    NumerMieszkania = "139"
                },
            },
            Adresat = new DaneUzytkownika()
            {
                Imie = "Maria",
                Nazwisko = "Janda",
                Adres = new Adres()
                {
                    Ulica = "Niebieska",
                    KodPocztowy = "01-999",
                    Miasto = "Białe Trzecie",
                    NumerMieszkania = "139"
                },
            },
            Status = new Status() { KodStatusu = 1, Kurier = daneKuriera2, Czas = new DateTime(1990, 10, 11) },
            PoczatekObslugi = new DateTime(1990, 10, 10),
            KoniecObslugi = new DateTime(1990, 10, 12)
        };

        GUPIEDaneSamochodu samochod2 = new GUPIEDaneSamochodu()
        {
            Id = 2,
            Marka = "Peugeot",
            Model = "Boxer",
            NumRejestracyjny = "PO L74B6",
            DataKontroli = new DateTime(2017, 3, 15),
            Stan = "Sprawny",
            Kurier = null
        };

        GUPIEDaneSamochodu samochod1 = new GUPIEDaneSamochodu()
        {
            Id = 1,
            Marka = "Citroen",
            Model = "Jumper",
            NumRejestracyjny = "PO 6478A",
            DataKontroli = new DateTime(2017, 3, 15),
            Stan = "Sprawny",
            Kurier = daneKuriera1
        };


    }
    public class GUPIEDaneSamochodu : Models.DTO.Samochod.DaneSamochodu
    {
        public Models.DTO.Uzytkownik.DaneKuriera Kurier { get; set; }
    }
}
