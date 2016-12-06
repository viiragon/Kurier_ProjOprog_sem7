using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Kurier.Models.Context;
using Kurier.Models.DTO;
using Kurier.Models.DTO.Uzytkownik;
using Microsoft.AspNet.Identity.EntityFramework;
using Kurier.Models.DTO.Samochod;
using Kurier.Models.DTO.Paczka;

namespace Kurier.Models.DataAccess
{
  public class AplicationDbInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ApplicationContext>
  {
    protected override void Seed(ApplicationContext context)
    {
      DaneKuriera daneKuriera1 = new DaneKuriera()
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
      };
      DaneKuriera daneKuriera2 = new DaneKuriera()
      {
        Imie = "Krystian",
        Nazwisko = "Nowakowski",
        Adres = new Adres()
        {
          KodPocztowy = "29-120",
          Miasto = "Kluczewsko",
          NumerMieszkania = "12",
          Ulica = "Spółdzielcza"
        }
      };

      DaneUzytkownika centrala = new DaneUzytkownika()
      {
        Imie = "Cichosław",
        Nazwisko = "Orzeł",
        Adres = new Adres()
        {
          Ulica = "Niebieska",
          KodPocztowy = "01-999",
          Miasto = "Białe Trzecie",
          NumerMieszkania = "139"
        }
      };

      DaneKlienta klient1 = new DaneKlienta()
      {
        Imie = "Wojciech",
        Nazwisko = "Kruk",
        Adres = new Adres()
        {
          KodPocztowy = "09-111",
          Miasto = "Starolas",
          NumerMieszkania = "13",
          Ulica = "Hymnu Miłości",
        }
      };
      DaneKlienta klient2 = new DaneKlienta()
      {
        Imie = "Ewa",
        Nazwisko = "Adamska",
        Adres = new Adres()
        {
          KodPocztowy = "13-616",
          Miasto = "Nowy Bór",
          NumerMieszkania = "69",
          Ulica = "Centralna",
        }

      };
      
      DaneSamochodu samochod1 = new DaneSamochodu()
      {
        Id = 1,
        NumRejestracyjny = "PO6478A",
        Stan = "Sprawny"

      };

      DaneSamochodu samochod2 = new DaneSamochodu()
      {
        Id = 2,
        NumRejestracyjny = "POL74B6",
        Stan = "Sprawny"

      };

//    ************   Paczka1   ************

      Status status1 = new Status()
      {
          Kurier = new DaneKuriera() {UserId = 1},
          KodStatusu = 1,
          Czas = new DateTime(2016, 12, 2),
      };

      Status status2 = new Status()
      {
          Kurier = new DaneKuriera() {UserId = 1},
          KodStatusu = 2,
          Czas = new DateTime(2016, 12, 4),
      };

      DanePaczki paczka1 = new DanePaczki()
      {
          Id = 1,
          Nadawca = new DaneKlienta()
          {
              UserId = 1,
              Adres = new Adres()
              {
                  Ulica = "Czekoladowa",
                  NumerMieszkania = "23",
                  KodPocztowy = "01-468",
                  Miasto = "Warszawa"
              }
          },
          Adresat = new DaneKlienta()
          {
              Adres = new Adres()
              {
                  Ulica = "Słowackiego",
                  NumerMieszkania = "8A/12",
                  KodPocztowy = "42-202",
                  Miasto = "Częstochowa"
              }
          },
          Status = status2,
          Historia = new List<Status>() { status1, status2 },
          PoczatekObslugi = new DateTime(2016, 12, 2),
          KoniecObslugi = new DateTime(2016, 12, 4)
      };

 //    ************   Paczka2   ************  
  
      Status status2_1 = new Status()
      {
          Kurier = new DaneKuriera() {UserId = 2},
          KodStatusu = 1,
          Czas = new DateTime(2016, 12, 4),
      };

      Status status2_2 = new Status()
      {
          Kurier = new DaneKuriera() {UserId = 2},
          KodStatusu = 2,
          Czas = new DateTime(2016, 12, 5),
      };

      DanePaczki paczka2 = new DanePaczki()
      {
          Id = 2,
          Nadawca = new DaneKlienta()
          {
              Adres = new Adres()
              {
                  Ulica = "Grochowska",
                  NumerMieszkania = "194/196",
                  KodPocztowy = "04-357",
                  Miasto = "Warszawa"
              }
          },
          Adresat = new DaneKlienta()
          {
              Adres = new Adres()
              {
                  Ulica = "Kościuszki",
                  NumerMieszkania = "3",
                  KodPocztowy = "03-356",
                  Miasto = "Pcim dolny"
              }
          },
          Status = status2_2,
          Historia = new List<Status>() { status2_1, status2_2 },
          PoczatekObslugi = new DateTime(2016, 12, 4),
          KoniecObslugi = new DateTime(2016, 12, 5)
      };

 //    ************   Paczka3   ************

      Status status3_1 = new Status()
      {
          Kurier = new DaneKuriera() {UserId = 1},
          KodStatusu = 1,
          Czas = new DateTime(2016, 12, 7),
      };

      DanePaczki paczka3 = new DanePaczki()
      {
          Id = 3,
          Nadawca = new DaneKlienta()
          {
              UserId = 2,
              Adres = new Adres()
              {
                  Ulica = "Skłodowskiej",
                  NumerMieszkania = "19",
                  KodPocztowy = "00-000",
                  Miasto = "Łódź"
              }
          },
          Adresat = new DaneKlienta()
          {
              Adres = new Adres()
              {
                  Ulica = "Emaus",
                  NumerMieszkania = "2",
                  KodPocztowy = "30-201",
                  Miasto = "Kraków"
              }
          },
          Status = status3_1,
          Historia = new List<Status>() {status3_1},
          PoczatekObslugi = new DateTime(2016, 12, 7)
      };

 //    ************   Paczka4   ************

      Status status4_1 = new Status()
      {
          KodStatusu = 1,
          Czas = new DateTime(2016, 12, 7),
      };

      DanePaczki paczka4 = new DanePaczki()
      {
          Id = 4,
          Nadawca = new DaneKlienta()
          {
              UserId = 1,
              Adres = new Adres()
              {
                  Ulica = "Czekoladowa",
                  NumerMieszkania = "23",
                  KodPocztowy = "01-468",
                  Miasto = "Warszawa"
              }
          },
          Adresat = new DaneKlienta()
          {
              Adres = new Adres()
              {
                  Ulica = "Grochowska",
                  NumerMieszkania = "194/196",
                  KodPocztowy = "04-357",
                  Miasto = "Warszawa"
              }
          },
          Status = status4_1,
          Historia = new List<Status>() {status4_1},
          PoczatekObslugi = new DateTime(2016, 12, 7)
      };

      context.Kurierzy.AddRange(new[] { daneKuriera1, daneKuriera2 });
      context.Klienci.AddRange(new[] { klient1, klient2 });
      context.Users.Add(centrala);
      context.Paczki.AddRange(new[] { paczka1, paczka2, paczka3, paczka4 });
      context.Samochody.AddRange(new[] { samochod1, samochod2 });
      context.SaveChanges();
            
    }
  }

}