using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using Kurier.Models.Context;
using Kurier.Models.DataAccess;
using Kurier.Models.DTO;
using Kurier.Models.DTO.Paczka;
using Kurier.Models.DTO.Samochod;
using Kurier.Models.DTO.Uzytkownik;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KurierTest.Models
{
  [TestClass]
  public class IMPaczkaTest
  {
    [TestMethod]
    public void DodajPaczkeTest()
    {
      DanePaczki paczka2 = new DanePaczki()
      {
        AdresAdresata = new Adres()
        {
          Ulica = "Niebieska",
          KodPocztowy = "01-999",
          Miasto = "Białe Trzecie",
          NumerMieszkania = "139"
        }
        ,
        PoczatekObslugi = new DateTime(1990, 10, 10),
        KoniecObslugi = new DateTime(1990, 10, 12),
        Id = 90
      };
      ApplicationContext context = MockMainteiner.PobierzContextPaczek(new List<DanePaczki>() { });

      new PaczkaModel(context).DodajPaczke(paczka2);
      DanePaczki pobranaPaczka = context.Paczki.FirstOrDefault(p => p.Id == paczka2.Id);
      Assert.AreEqual(pobranaPaczka, paczka2);

    }
    [TestMethod]
    public void PobierzListePaczekTest()
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
        UserId = 3
      };

      DanePaczki paczka1 = new DanePaczki()
      {
        AdresAdresata = new Adres()
        {
          KodPocztowy = "29-120",
          Miasto = "Kluczewsko",
          NumerMieszkania = "12",
          Ulica = "Spółdzielcza"
        },
        Status = new Status() { Kurier = daneKuriera1, Czas = new DateTime(1990, 10, 11) }
        ,
        PoczatekObslugi = new DateTime(1990, 10, 10),
        KoniecObslugi = new DateTime(1990, 10, 12)
      };

      DanePaczki paczka2 = new DanePaczki()
      {
        AdresAdresata = new Adres()
        {
          Ulica = "Niebieska",
          KodPocztowy = "01-999",
          Miasto = "Białe Trzecie",
          NumerMieszkania = "139"
        }
        ,
        PoczatekObslugi = new DateTime(1990, 10, 10),
        KoniecObslugi = new DateTime(1990, 10, 12)
      };
      ApplicationContext context = MockMainteiner.PobierzContextKurierow(new List<DaneKuriera>() { daneKuriera1 },
        paczki: new List<DanePaczki>() { paczka1, paczka2 });
      var list = new PaczkaModel(context).PobierzListePaczek();

      Assert.AreEqual(list[0], paczka1);
      Assert.AreEqual(list[1], paczka2);

    }

    [TestMethod]
    public void PobierzPaczkeTest()
    {
      DanePaczki paczka1 = new DanePaczki()
      {
        AdresAdresata = new Adres()
        {
          KodPocztowy = "29-120",
          Miasto = "Kluczewsko",
          NumerMieszkania = "12",
          Ulica = "Spółdzielcza"
        },
        Status = new Status() { Czas = new DateTime(1990, 10, 11) }
        ,
        PoczatekObslugi = new DateTime(1990, 10, 10),
        KoniecObslugi = new DateTime(1990, 10, 12)
      };
      DanePaczki paczka2 = new DanePaczki()
      {
        AdresAdresata = new Adres()
        {
          Ulica = "Niebieska",
          KodPocztowy = "01-999",
          Miasto = "Białe Trzecie",
          NumerMieszkania = "139"
        }
        ,
        PoczatekObslugi = new DateTime(1990, 10, 10),
        KoniecObslugi = new DateTime(1990, 10, 12),
        Id = 6
      };
      ApplicationContext context = MockMainteiner.PobierzContextPaczek(new List<DanePaczki>() { paczka1, paczka2 });
      DanePaczki paczkaPobrana = new PaczkaModel(context).PobierzPaczke(paczka2.Id);

      Assert.AreEqual(paczka2, paczkaPobrana);

    }

    [TestMethod]
    public void ZmienStatusPaczkiTest()
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
        UserId = 3
      };

      DanePaczki paczka1 = new DanePaczki()
      {
        AdresAdresata = new Adres()
        {
          KodPocztowy = "29-120",
          Miasto = "Kluczewsko",
          NumerMieszkania = "12",
          Ulica = "Spółdzielcza"
        },
        Status = new Status() { Czas = new DateTime(1990, 10, 11) }
       ,
        PoczatekObslugi = new DateTime(1990, 10, 10),
        KoniecObslugi = new DateTime(1990, 10, 12),
        Id = 6
      };
      Status status = new Status()
      {
        Czas = new DateTime(1990, 10, 01),
        Id = 9,
        KodStatusu = 19,
        Kurier = daneKuriera1
      };

      var context = MockMainteiner.PobierzContextPaczek(new List<DanePaczki>() { paczka1 });
      new PaczkaModel(context).ZmienStatusPaczki(status, paczka1.Id);
      var paczkaZeZmienionymStanem = context.Paczki.FirstOrDefault(p => p.Id == paczka1.Id);

      Assert.IsNotNull(paczkaZeZmienionymStanem);
      Assert.AreEqual(paczkaZeZmienionymStanem.Status, status);
    }

    [TestMethod]
    public void PowiazKurieraIPaczkeTest()
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
        UserId = 3
      };

      DanePaczki paczka1 = new DanePaczki()
      {
        AdresAdresata = new Adres()
        {
          KodPocztowy = "29-120",
          Miasto = "Kluczewsko",
          NumerMieszkania = "12",
          Ulica = "Spółdzielcza"
        },
        Status = new Status() { Czas = new DateTime(1990, 10, 11) },
        PoczatekObslugi = new DateTime(1990, 10, 10),
        KoniecObslugi = new DateTime(1990, 10, 12),
        Id = 6
      };
      var context = MockMainteiner.PobierzContextKurierow(new List<DaneKuriera>() {daneKuriera1},
        paczki: new List<DanePaczki>() {paczka1});
      new  PaczkaModel(context).PowiazKurieraIPaczke(paczka1.Id,daneKuriera1.UserId);
      var powiazanaPaczka = context.Paczki.FirstOrDefault(p => p.Id == paczka1.Id);
      Assert.IsNotNull(powiazanaPaczka);
      Assert.AreEqual(powiazanaPaczka.Status.Kurier,daneKuriera1);

    }



  }
}
