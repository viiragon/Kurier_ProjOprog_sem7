using System;
using System.Collections.Generic;
using System.Linq;
using Castle.Components.DictionaryAdapter;
using Kurier.Models.Context;
using Kurier.Models.DataAccess;
using Kurier.Models.DTO;
using Kurier.Models.DTO.Paczka;
using Kurier.Models.DTO.Samochod;
using Kurier.Models.DTO.Uzytkownik;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace KurierTest.Models
{
  [TestClass]
  public class IMKurierTest
  {
    [TestMethod]
    public void DodajKurieraTest()
    {
      var data = new List<DaneKuriera>();
      DaneKuriera daneKuriera = new DaneKuriera()
      {
        Adres = new Adres()
        {
          KodPocztowy = "44-44",
          Miasto = "Sierpc",
          NumerMieszkania = "2",
          Ulica = "Poniatowskiego"
        },
        Nazwisko = "Mirosławski",
        Imie = "Stanisław",
        NumerPracowanika = 100
      };

      var context = MockMainteiner.PobierzContextKurierow(data);

      new KurierzyModel(context).DodajKuriera(daneKuriera);

      DaneKuriera pobraneDaneKuriera = context.Kurierzy.FirstOrDefault(
        p => p.Imie == "Stanisław"
             && p.Nazwisko == "Mirosławski"
             && p.Adres.KodPocztowy == "44-44"
             && p.Adres.Miasto == "Sierpc"
             && p.Adres.NumerMieszkania == "2"
             && p.Adres.Ulica == "Poniatowskiego"
             && p.NumerPracowanika == 100
      );

      Assert.IsNotNull(pobraneDaneKuriera);

    }
    [TestMethod]
    public void PobierzKurieraTest()
    {
      DaneKuriera daneKuriera = new DaneKuriera()
      {
        Adres = new Adres()
        {
          KodPocztowy = "44-44",
          Miasto = "Sierpc",
          NumerMieszkania = "2",
          Ulica = "Poniatowskiego"
        },
        Nazwisko = "Mirosławski",
        Imie = "Stanisław",
        NumerPracowanika = 100,
        UserId = 10
      };
      var data = new List<DaneKuriera>() { daneKuriera };
      var context = MockMainteiner.PobierzContextKurierow(data);

      DaneKuriera pobraneDaneKuriera = new KurierzyModel(context).PobierzKuriera(10);
      Assert.AreEqual(pobraneDaneKuriera.NumerPracowanika, 100);
      Assert.AreEqual(pobraneDaneKuriera.Imie, "Stanisław");
      Assert.AreEqual(pobraneDaneKuriera.Nazwisko, "Mirosławski");
      Assert.AreEqual(pobraneDaneKuriera.Adres.KodPocztowy, "44-44");
      Assert.AreEqual(pobraneDaneKuriera.Adres.Miasto, "Sierpc");
      Assert.AreEqual(pobraneDaneKuriera.Adres.NumerMieszkania, "2");
      Assert.AreEqual(pobraneDaneKuriera.Adres.Ulica, "Poniatowskiego");
      Assert.AreEqual(pobraneDaneKuriera.UserId, 10);

    }
    [TestMethod]
    public void PobierzNieistniejacegoKurieraTest()
    {
      DaneKuriera daneKuriera = new DaneKuriera()
      {
        Adres = new Adres()
        {
          KodPocztowy = "44-44",
          Miasto = "Sierpc",
          NumerMieszkania = "2",
          Ulica = "Poniatowskiego"
        },
        Nazwisko = "Mirosławski",
        Imie = "Stanisław",
        NumerPracowanika = 100,
        UserId = 10
      };
      var data = new List<DaneKuriera>() { daneKuriera };
      var context = MockMainteiner.PobierzContextKurierow(data);

      DaneKuriera pobraneDaneKuriera = new KurierzyModel(context).PobierzKuriera(101);
      Assert.IsNull(pobraneDaneKuriera);

    }
    [TestMethod]
    public void PobierzListeKurierowTest()
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

      var data = new List<DaneKuriera>() { daneKuriera1, daneKuriera2 };
      List<DaneKuriera> list = new KurierzyModel(MockMainteiner.PobierzContextKurierow(data)).PobierzListeKurierow();

      Assert.AreEqual(2, list.Count);
      Assert.AreEqual(list[0].Imie, daneKuriera1.Imie);
      Assert.AreEqual(list[0].Nazwisko, daneKuriera1.Nazwisko);
      Assert.AreEqual(list[0].Adres.NumerMieszkania, daneKuriera1.Adres.NumerMieszkania);
      Assert.AreEqual(list[0].Adres.KodPocztowy, daneKuriera1.Adres.KodPocztowy);
      Assert.AreEqual(list[0].Adres.Ulica, daneKuriera1.Adres.Ulica);
      Assert.AreEqual(list[0].Adres.Miasto, daneKuriera1.Adres.Miasto);

      Assert.AreEqual(list[1].Imie, daneKuriera2.Imie);
      Assert.AreEqual(list[1].Nazwisko, daneKuriera2.Nazwisko);
      Assert.AreEqual(list[1].Adres.NumerMieszkania, daneKuriera2.Adres.NumerMieszkania);
      Assert.AreEqual(list[1].Adres.KodPocztowy, daneKuriera2.Adres.KodPocztowy);
      Assert.AreEqual(list[1].Adres.Ulica, daneKuriera2.Adres.Ulica);
      Assert.AreEqual(list[1].Adres.Miasto, daneKuriera2.Adres.Miasto);

    }

    [TestMethod]
    public void PobierzPustaListeKurierowTest()
    {
      var data = new List<DaneKuriera>();
      List<DaneKuriera> list = new KurierzyModel(MockMainteiner.PobierzContextKurierow(data)).PobierzListeKurierow();
      Assert.AreEqual(0, list.Count);
    }

    [TestMethod]
    public void PobierzListePaczekKurieraTest()
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
        Adres = new Adres()
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
        Adres = new Adres()
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

      var context = MockMainteiner.PobierzContextKurierow(new List<DaneKuriera>() { daneKuriera1 },
        paczki: new List<DanePaczki>() { paczka1, paczka2 });
      List<DanePaczki> paczki = (new KurierzyModel(context).PobierzListePaczekKuriera(3));
      Assert.AreEqual(1, paczki.Count);
      Assert.AreEqual(paczki[0].Adres.Ulica, paczka1.Adres.Ulica);
      Assert.AreEqual(paczki[0].Adres.KodPocztowy, paczka1.Adres.KodPocztowy);
      Assert.AreEqual(paczki[0].Adres.Miasto, paczka1.Adres.Miasto);
      Assert.AreEqual(paczki[0].Adres.NumerMieszkania, paczka1.Adres.NumerMieszkania);
      Assert.AreEqual(paczki[0].KoniecObslugi, paczka1.KoniecObslugi);
      Assert.AreEqual(paczki[0].PoczatekObslugi, paczka1.PoczatekObslugi);
      Assert.AreEqual(paczki[0].Status.Kurier.Id, paczka1.Status.Kurier.Id);
      Assert.AreEqual(paczki[0].Status.Czas, paczka1.Status.Czas);

    }

    [TestMethod]
    public void PobierzListePaczekKurieraBezPaczekTest()
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
        Adres = new Adres()
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
        Adres = new Adres()
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

      var context = MockMainteiner.PobierzContextKurierow(new List<DaneKuriera>() { daneKuriera1 },
        paczki: new List<DanePaczki>() { paczka1, paczka2 });
      List<DanePaczki> paczki = (new KurierzyModel(context).PobierzListePaczekKuriera(3));
      Assert.AreEqual(0, paczki.Count);
    }

    [TestMethod]
    public void PobierzSamochodKurieraTest()
    {

      var samochod = new DaneSamochodu()
      {
        Id = 5,
        NumRejestracyjny = "WTS9231",
        Stan = "sprawny"
      };
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
        UserId = 3,
        Samochod = samochod
      };

      var context = MockMainteiner.PobierzContextKurierow(new List<DaneKuriera>() { daneKuriera1 }, samochody: new List<DaneSamochodu>() { samochod });
      DaneSamochodu pobranySamochod = new KurierzyModel(context).PobierzSamochodKuriera(3);
      Assert.AreEqual(samochod.Id, pobranySamochod.Id);
      Assert.AreEqual(samochod.NumRejestracyjny, pobranySamochod.NumRejestracyjny);
      Assert.AreEqual(samochod.Stan, pobranySamochod.Stan);
    }
    [TestMethod]
    public void PobierzSamochodKurieraBezSamochoduTest()
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

      var samochod = new DaneSamochodu()
      {
        Id = 5,
        NumRejestracyjny = "WTS9231",
        Stan = "sprawny"
      };
      var context = MockMainteiner.PobierzContextKurierow(new List<DaneKuriera>() { daneKuriera1 }, samochody: new List<DaneSamochodu>() { samochod });
      DaneSamochodu pobranySamochod = new KurierzyModel(context).PobierzSamochodKuriera(3);
      Assert.IsNull(pobranySamochod);
    }




  }
}
