using System.Collections.Generic;
using System.Data.Entity.Validation;
using Kurier.Models.Context;
using Kurier.Models.DataAccess;
using Kurier.Models.DTO;
using Kurier.Models.DTO.Paczka;
using Kurier.Models.DTO.Samochod;
using Kurier.Models.DTO.Uzytkownik;

namespace Kurier.Migrations
{
  using System;
  using System.Data.Entity;
  using System.Data.Entity.Migrations;
  using System.Linq;

  internal sealed class Configuration : DbMigrationsConfiguration<Kurier.Models.Context.ApplicationContext>
  {
    public Configuration()
    {
      AutomaticMigrationsEnabled = false;
    }

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
        UserName = "kmaci"
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
          Ulica = "Spó³dzielcza"
        },
        UserName = "knowa"
      };

      DaneUzytkownika centrala = new DaneUzytkownika()
      {
        Imie = "Cichos³aw",
        Nazwisko = "Orze³",
        Adres = new Adres()
        {
          Ulica = "Niebieska",
          KodPocztowy = "01-999",
          Miasto = "Bia³e Trzecie",
          NumerMieszkania = "139"
        },
        UserName = "corze"
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
          Ulica = "Hymnu Mi³oœci",
        },
        UserName = "wkruk"

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
        },
        UserName = "eadam"

      };

      DaneSamochodu samochod1 = new DaneSamochodu()
      {
       
        Marka = "Citroen",
        Model = "Jumper",
        NumRejestracyjny = "PO6478A",
        DataKontroli = new DateTime(2017, 03, 15),
        Stan = "Sprawny"

      };

      DaneSamochodu samochod2 = new DaneSamochodu()
      {
   
        Marka = "Peugeot",
        Model = "Boxer",
        NumRejestracyjny = "POL74B6",
        DataKontroli = new DateTime(2017, 03, 17),
        Stan = "Sprawny"

      };

      DaneUzytkownika nadawca1 = new DaneUzytkownika()
      {
        Adres = new Adres()
        {
          Ulica = "Czekoladowa",
          NumerMieszkania = "23",
          KodPocztowy = "01-468",
          Miasto = "Warszawa"
        },
        UserName = "user1"
      };

      DaneUzytkownika adresat1 = new DaneUzytkownika()
      {
        Adres = new Adres()
        {
          Ulica = "S³owackiego",
          NumerMieszkania = "8A/12",
          KodPocztowy = "42-202",
          Miasto = "Czêstochowa"
        },
        UserName = "user2"
      };

      //    ************   Paczka1   ************

      Status status1 = new Status()
      {
        Kurier = context.Kurierzy.FirstOrDefault(p => p.UserName == daneKuriera1.UserName) ?? daneKuriera1,
        KodStatusu = 1,
        Czas = new DateTime(2016, 12, 2),
      };

      Status status2 = new Status()
      {
        Kurier = context.Kurierzy.FirstOrDefault(p => p.UserName == daneKuriera1.UserName) ?? daneKuriera1,
        KodStatusu = 2,
        Czas = new DateTime(2016, 12, 4),
      };

      DanePaczki paczka1 = new DanePaczki()
      {
        AdresNadawcy =  adresat1.Adres,
        AdresAdresata = nadawca1.Adres,
        Status = (Status)status2.Clone(),
        Historia = new List<Status>() { status1, status2 },
        PoczatekObslugi = new DateTime(2016, 12, 2),
        KoniecObslugi = new DateTime(2016, 12, 4)
      };

      //    ************   Paczka2   ************  

      Status status2_1 = new Status()
      {
        Kurier = context.Kurierzy.FirstOrDefault(p=>p.UserName==daneKuriera2.UserName) ?? daneKuriera2,
        KodStatusu = 1,
        Czas = new DateTime(2016, 12, 4),
      };

      Status status2_2 = new Status()
      {
        Kurier = context.Kurierzy.FirstOrDefault(p => p.UserName == daneKuriera2.UserName) ?? daneKuriera2,
        KodStatusu = 2,
        Czas = new DateTime(2016, 12, 5),
      };
      DaneUzytkownika nadawca2 = new DaneUzytkownika()
      {
        Adres = new Adres()
        {
          Ulica = "Grochowska",
          NumerMieszkania = "194/196",
          KodPocztowy = "04-357",
          Miasto = "Warszawa"
        },
        UserName = "user3"
      };
      DaneUzytkownika adresat2 = new DaneUzytkownika()
      {
        Adres = new Adres()
        {
          Ulica = "Koœciuszki",
          NumerMieszkania = "3",
          KodPocztowy = "03-356",
          Miasto = "Pcim dolny"
        },
        UserName = "user4"

      };
      DanePaczki paczka2 = new DanePaczki()
      {
        AdresNadawcy =  nadawca2.Adres,
        AdresAdresata = adresat2.Adres,
        Status = (Status)status2_2.Clone(),
        Historia = new List<Status>() { status2_1, status2_2 },
        PoczatekObslugi = new DateTime(2016, 12, 4),
        KoniecObslugi = new DateTime(2016, 12, 5)
      };

      //    ************   Paczka3   ************

      Status status3_1 = new Status()
      {
        Kurier = context.Kurierzy.FirstOrDefault(p => p.UserName == daneKuriera1.UserName) ?? daneKuriera1,
        KodStatusu = 1,
        Czas = new DateTime(2016, 12, 7),
      };
      DaneUzytkownika nadawca3 = new DaneUzytkownika()
      {
        Adres = new Adres()
        {
          Ulica = "Sk³odowskiej",
          NumerMieszkania = "19",
          KodPocztowy = "00-000",
          Miasto = "£ódŸ"
        },
        UserName = "user5"
      };
      var adresat3 = new DaneUzytkownika()
      {
        Adres = new Adres()
        {
          Ulica = "Emaus",
          NumerMieszkania = "2",
          KodPocztowy = "30-201",
          Miasto = "Kraków"
        },
        UserName = "user6"
      };
      DanePaczki paczka3 = new DanePaczki()
      {
        AdresNadawcy = nadawca3.Adres,
        AdresAdresata = adresat3.Adres,
        Status = (Status)status3_1.Clone(),
        Historia = new List<Status>() { status3_1 },
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
        AdresNadawcy =  new Adres()
          {
            Ulica = "Czekoladowa",
            NumerMieszkania = "23",
            KodPocztowy = "01-468",
            Miasto = "Warszawa"
          },
        AdresAdresata =  new Adres()
          {
            Ulica = "Grochowska",
            NumerMieszkania = "194/196",
            KodPocztowy = "04-357",
            Miasto = "Warszawa"
          },
         
        Status = (Status)status4_1.Clone(),
        Historia = new List<Status>() { status4_1 },
        PoczatekObslugi = new DateTime(2016, 12, 7)
      };
      if (context.Kurierzy.FirstOrDefault(p => p.UserName == daneKuriera1.UserName) == null)
      {
        context.Kurierzy.Add(daneKuriera1);
      }
      if (context.Kurierzy.FirstOrDefault(p => p.UserName == daneKuriera2.UserName) == null)
      {
        context.Kurierzy.Add(daneKuriera2);
      }
      if (context.Klienci.FirstOrDefault(p => p.UserName == klient1.UserName) == null)
      {
        context.Klienci.Add(klient1);
      }
      if (context.Klienci.FirstOrDefault(p => p.UserName == klient2.UserName) == null)
      {
        context.Klienci.Add(klient2);
      }

      if (context.Users.FirstOrDefault(p=>p.UserName==nadawca1.UserName)==null)
      {
        context.Users.Add(nadawca1);
      }
      if (context.Users.FirstOrDefault(p => p.UserName == nadawca2.UserName) == null)
      {
        context.Users.Add(nadawca2);
      }
      if (context.Users.FirstOrDefault(p => p.UserName == nadawca3.UserName) == null)
      {
        context.Users.Add(nadawca3);
      }
      if (context.Users.FirstOrDefault(p => p.UserName == adresat1.UserName) == null)
      {
        context.Users.Add(adresat1);
      }
      if (context.Users.FirstOrDefault(p => p.UserName == adresat2.UserName) == null)
      {
        context.Users.Add(adresat2);
      }
      if (context.Users.FirstOrDefault(p => p.UserName == adresat3.UserName) == null)
      {
        context.Users.Add(adresat3);
      }
      if (context.Users.FirstOrDefault(p => p.UserName == centrala.UserName) == null)
      {
        context.Users.Add(centrala);
      }


      context.Paczki.AddRange(new[] { paczka1, paczka2, paczka3, paczka4 });

   

      context.Samochody.AddRange(new[] { samochod1, samochod2 });

      try
      {
        context.SaveChanges();
      }
      catch (DbEntityValidationException e)
      {

      }

    }

  }
}
