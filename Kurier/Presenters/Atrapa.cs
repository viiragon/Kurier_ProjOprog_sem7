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

        public static Atrapa instance = new Atrapa();
        public static ICMLogowanie PCentrLogowanie;
        public static ICMSamochody PCentrSamochody;
        public static ICMStatystyka PCentrStatystyka;
        public static ICMKurierzy PCentrKurierzy;
        public static ICMPaczki PCentrPaczki;

        public static IPKurier PKurier;
        public static IPKlient PKlient;

        public static Interfaces.View.IVCentralaLogowanie logowanie;
        public static Interfaces.View.IVCentralaStatystyka statystyka;
        public static Interfaces.View.IVCentralaPaczki paczki;
        public static Interfaces.View.IVCentralaSamochody samochody;
        public static Interfaces.View.IVCentralaKurierzy kurierzy;

        public static Interfaces.View.IVKurier ivKurier;
        public static Interfaces.View.IVKlient ivKlient;


        public Atrapa()
        {
            bool atrapimy = false;

            PCentrLogowanie = atrapimy && true
                ? this as Interfaces.Presenter.ICMLogowanie
                : new Presenters.CentralaManager.Logowanie.LogowaniePrezenter();
            PCentrStatystyka = atrapimy && true
                ? this as Interfaces.Presenter.ICMStatystyka
                : new Presenters.CentralaManager.StatystykiCM.StatystykiPrezenter();
            PCentrSamochody = atrapimy && true
                ? this as Interfaces.Presenter.ICMSamochody
                : new Presenters.CentralaManager.SamochodyCM.SamochodyPrezenter();
            PCentrPaczki = atrapimy && true
                ? this as Interfaces.Presenter.ICMPaczki
                : new Presenters.CentralaManager.PaczkiCM.PaczkiPrezenter();
            PCentrKurierzy = atrapimy && true
                ? this as Interfaces.Presenter.ICMKurierzy
                : new Presenters.CentralaManager.KurierzyCM.KurierzyPrezenter(PCentrPaczki);
            PKurier = this/*atrapimy  && true
                ? this as Interfaces.Presenter.IPKurier
                : new Presenters.KurierManager.KurierPrezenter()*/;
            PKlient = atrapimy && true
                ? this as Interfaces.Presenter.IPKlient
                : new Presenters.KlientManager.KlientPrezenter();
            logowanie = Interfaces.View.IVCentralaLogowanie.createInstance(PCentrLogowanie);
            statystyka = Interfaces.View.IVCentralaStatystyka.createInstance(PCentrStatystyka);
            paczki = Interfaces.View.IVCentralaPaczki.createInstance(PCentrPaczki);
            samochody = Interfaces.View.IVCentralaSamochody.createInstance(PCentrSamochody);
            kurierzy = Interfaces.View.IVCentralaKurierzy.createInstance(PCentrKurierzy, PCentrPaczki);

            ivKurier = Interfaces.View.IVKurier.createInstance(PKurier);
            ivKlient = Interfaces.View.IVKlient.createInstance(PKlient);

            init();
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
            DaneKuriera[] lista = new DaneKuriera[2];

            lista[0] = daneKuriera1;
            lista[1] = daneKuriera2;

            kurierzy.wyswietlOknoListyKurierow(lista);
        }

        public void wybranoPokazSzczegolyKuriera(int id)
        {
            if (id == daneKuriera1.UserId)
            {
                kurierzy.wyswietlOknoSzczegolowKuriera(daneKuriera1, null);
            }
            else
            {
                kurierzy.wyswietlOknoSzczegolowKuriera(daneKuriera2, null);
            }
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
            samochody.wyswietlOknoListySamochodow(new Models.DTO.Samochod.DaneSamochodu[] { samochod1, samochod2 }, null);
        }

        public void wybranoPokazSzczegolySamochodu(int id)
        {
            DaneSamochodu retSamochod = id == samochod1.Id ? samochod1 : samochod2;
            DaneKuriera kurier = daneKuriera1.Samochod == retSamochod ? daneKuriera1 : daneKuriera2.Samochod == retSamochod ? daneKuriera2 : null;
            samochody.wyswietlOknoSzczegolowSamochodu(retSamochod, kurier);
        }

        public void wybranoPrzypiszKurieraDoSamochodu(int idSamochodu)
        {
            samochody.wyswietlOknoPrzypisaniaSamochoduDoKuriera(idSamochodu, new DaneKuriera[] { daneKuriera1, daneKuriera2 });
        }

        public void wybranoUsunSamochod(int id)
        {
            DaneSamochodu samochod = id == samochod1.Id ? samochod2 : samochod1;
            samochody.wyswietlOknoListySamochodow(new Models.DTO.Samochod.DaneSamochodu[] { samochod }, "Samochód został usunięty");
        }

        public void wybranoWyslijZlecenieDoSerwisu(Models.DTO.Samochod.DaneSamochodu dane)
        {
            samochody.wyswietlOknoWysylaniaZleceniaDoSerwisu(dane);
        }

        public void wybranoZapiszNowySamochod(Models.DTO.Samochod.DaneSamochodu dane)
        {
            dane.Id = samochod2.Id + 1;
            samochody.wyswietlOknoListySamochodow(new Models.DTO.Samochod.DaneSamochodu[] { samochod1, samochod2, dane }, "Samochód został dodany");
        }

        public void wybranoZapiszPowiazanieKurieraZSamochodem(int idSamochodu, int idKuriera)
        {
            if (idKuriera == -1)
            {
                DaneSamochodu samochod = idSamochodu == samochod1.Id ? samochod1 : samochod2;
                DaneKuriera kurier = daneKuriera1.Samochod == samochod ? daneKuriera1 : daneKuriera2;
                kurier.Samochod = null;
                samochody.wyswietlOknoSzczegolowSamochoduZKomunikatem(samochod, "Usunięto przypisanie", null);
            }
            else
            {
                DaneKuriera kurier = idKuriera == daneKuriera1.UserId ? daneKuriera1 : daneKuriera2;
                DaneSamochodu samochod = idSamochodu == samochod1.Id ? samochod1 : samochod2;
                kurier.Samochod = samochod;
                samochody.wyswietlOknoSzczegolowSamochoduZKomunikatem(samochod, "Przypisano kuriera", kurier);
            }
            //samochody.wyswietlOknoSzczegolowSamochoduZKomunikatem(samochod, "Przypisano kuriera", kurier);
        }

        public void wybranoEdytujStatusPaczki(int id)
        {
            throw new NotImplementedException();
        }

        public void wybranoPokazSzczegolyKurieraDlaPaczki(int id)
        {
            DanePaczki paczka;
            if (id == paczka1.Id)
            {
                paczka = paczka1;
            }
            else
            {
                paczka = paczka2;
            }
            if (paczka.Status.Kurier != null)
            {
                kurierzy.wyswietlOknoSzczegolowKuriera(paczka.Status.Kurier, null);
            }
            else
            {
                kurierzy.wyswietlOknoPrzypisywaniaKurieraDoPaczki(new DaneKuriera[] { daneKuriera1, daneKuriera2 }, paczka.Id);
            }
        }

        public void wybranoPokazListePaczek()
        {
            DanePaczki[] listaPaczek = new Models.DTO.Paczka.DanePaczki[2];

            listaPaczek[0] = paczka1;
            listaPaczek[1] = paczka2;

            paczki.wyswietlOknoListyPaczek(listaPaczek);
        }

        public void wybranoPokazSzczegolyPaczki(int id)
        {
            if (id == paczka1.Id)
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

        public void wybranoZapiszPowiazanieKurieraZPaczka(int idPaczki, int idKuriera)
        {
            DaneKuriera tmpKurier;
            DanePaczki paczka;
            if (idKuriera == daneKuriera1.UserId) { tmpKurier = daneKuriera1; } else { tmpKurier = daneKuriera2; }
            if (idPaczki == paczka1.Id) { paczka = paczka1; } else { paczka = paczka2; }
            paczka.Status.Kurier = tmpKurier;
            kurierzy.wyswietlOknoSzczegolowKuriera(tmpKurier, "Przypisano kuriera do paczki");
        }

        public void wybranoZapiszStatusPaczkiDlaCentrali(Models.DTO.Paczka.Status status, int idPaczki)
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
            ivKurier.wyswietlOknoPrzypisanegoSamochodu(daneKuriera1.Samochod);
        }

        public void wybranoWydajPaczke(DanePaczki paczka)
        {
            throw new NotImplementedException();
        }

        public void wybranoWylogujKuriera()
        {
            ivKurier.wyswietlFormularzLogowaniaJakoKurier();
        }

        public void wybranoZapiszStatusPaczki(Models.DTO.Paczka.Status status, int idPaczki)
        {
            DanePaczki paczka;
            if (idPaczki == paczka1.Id) { paczka = paczka1; } else { paczka = paczka2; }
            paczka.Status = status;
            string komunikat;
            if (paczka.Status.KodStatusu == (int)StatusEnum.WDrodze)
            {
                komunikat = "Paczka została wydana";
            }
            else
            {
                komunikat = "Paczka została doręczona";
            }
            ivKurier.wyswietlOknoListyZlecenKurieraZKomunikatemOPrzegladzie(daneKuriera1, new Models.DTO.Paczka.DanePaczki[] { paczka1, paczka2 }, daneKuriera1.Samochod, komunikat);
        }

        public void wybranoZalogujKuriera(DaneUzytkownika dane)
        {
            if (dane.Login.Equals("mkowa") && dane.Haslo.Equals("natak139a"))
            {
                Models.DTO.Uzytkownik.DaneKuriera user = daneKuriera1;
                user.Login = dane.Login;
                user.Haslo = dane.Haslo;
                //ivKurier.wyswietlOknoListyZlecenKuriera(user, new Models.DTO.Paczka.DanePaczki[] { paczka1, paczka2 });
                MainLauncher.message(user.Samochod + "");
                ivKurier.wyswietlOknoListyZlecenKurieraZKomunikatemOPrzegladzie(user, new Models.DTO.Paczka.DanePaczki[] { paczka1, paczka2 }, daneKuriera1.Samochod, null);
            }
        }

        public void wybranoPokazSzczegolyPaczkiDlaKuriera(int id)
        {
            throw new NotImplementedException();
        }

        Models.DTO.Uzytkownik.DaneKuriera daneKuriera1, daneKuriera2;
        DanePaczki paczka1, paczka2;
        DaneUzytkownika klient1, klient2;
        DaneSamochodu samochod1, samochod2;

        private void init()
        {
            klient1 = new DaneUzytkownika()
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
                };

            klient2 = new DaneUzytkownika()
            {
                Imie = "Maria",
                Nazwisko = "Janda",
                Adres = new Adres()
                {
                    KodPocztowy = "29-120",
                    Miasto = "Kluczewsko",
                    NumerMieszkania = "12",
                    Ulica = "Spółdzielcza"
                },
            };

            samochod1 = new DaneSamochodu()
            {
                Id = 1,
                Marka = "Citroen",
                Model = "Jumper",
                NumRejestracyjny = "PO 6478A",
                DataKontroli = new DateTime(2017, 3, 15),
                Stan = "Sprawny",
            };
            
            samochod2 = new DaneSamochodu()
            {
                Id = 2,
                Marka = "Peugeot",
                Model = "Boxer",
                NumRejestracyjny = "PO L74B6",
                DataKontroli = new DateTime(2017, 3, 15),
                Stan = "Sprawny",
            };

            daneKuriera1 = new Models.DTO.Uzytkownik.DaneKuriera()
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
                UserId = 1,
                Samochod = samochod1
            };

            daneKuriera2 = new Models.DTO.Uzytkownik.DaneKuriera()
            {
                Adres = new Adres()
                {
                    KodPocztowy = "29-120",
                    Miasto = "Kluczewsko",
                    NumerMieszkania = "12",
                    Ulica = "Spółdzielcza"
                },
                Nazwisko = "Nowakowski",
                Imie = "Krystian",
                UserId = 2,
                Samochod = samochod2
            };

            paczka1 = new DanePaczki()
            {
                Id = 312,
                IdPaczki = "2/12/2016",
                AdresAdresata = klient2.Adres,
                Nadawca = klient1,
                Adresat = klient2,
                Status = new Status() { KodStatusu = (int)StatusEnum.Doreczona, Kurier = daneKuriera1, Czas = new DateTime(1990, 10, 11) },
                //Historia = new List<Status>() { new Status() { KodStatusu = 0, Czas = new DateTime(2016, 12, 02) }, new Status() { KodStatusu = 1, Czas = new DateTime(2016, 12, 04) } },
                PoczatekObslugi = new DateTime(2016, 12, 02),
                KoniecObslugi = new DateTime(2016, 12, 04)
            };

            paczka2 = new DanePaczki()
            {
                Id = 212,
                IdPaczki = "4/12/2016",
                AdresAdresata = klient1.Adres,
                Nadawca = klient2,
                Adresat = klient1,
                Status = new Status() { KodStatusu = (int)StatusEnum.Nadana, Kurier = null, Czas = new DateTime(1990, 10, 11) },
                PoczatekObslugi = new DateTime(1990, 10, 10),
                KoniecObslugi = new DateTime(1990, 10, 12)
            };
        }
    }
}
