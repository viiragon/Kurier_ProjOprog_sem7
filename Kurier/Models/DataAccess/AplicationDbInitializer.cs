using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Kurier.Models.Context;
using Kurier.Models.DTO;
using Kurier.Models.DTO.Uzytkownik;
using Microsoft.AspNet.Identity.EntityFramework;

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
      context.Kurierzy.AddRange(new[] { daneKuriera1, daneKuriera2 });
      context.Klienci.AddRange(new[] { klient1, klient2 });
      context.Uzytkownicy.Add(centrala);
      context.SaveChanges();


    }
  }

}