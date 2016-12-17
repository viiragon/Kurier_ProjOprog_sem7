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
      var context = MockMainteiner.PobierzContextKurierow(new List<DaneKuriera>());

      new KurierzyModel(context).DodajKuriera(TestDataFactory.DaneKuriera);

      DaneKuriera daneKuriera = TestDataFactory.DaneKuriera;

      DaneKuriera pobraneDaneKuriera = context.Kurierzy.FirstOrDefault(
        p => p.Imie == daneKuriera.Imie
             && p.Nazwisko == daneKuriera.Nazwisko
             && p.Adres.KodPocztowy == daneKuriera.Adres.KodPocztowy
             && p.Adres.Miasto == daneKuriera.Adres.Miasto
             && p.Adres.NumerMieszkania == daneKuriera.Adres.NumerMieszkania
             && p.Adres.Ulica == daneKuriera.Adres.Ulica
             && p.NumerPracowanika == daneKuriera.NumerPracowanika
      );

      Assert.IsNotNull(pobraneDaneKuriera);
      pobraneDaneKuriera.Equals(daneKuriera);
      Assert.AreEqual(pobraneDaneKuriera, daneKuriera);
    }

    [TestMethod]
    public void PobierzKurieraTest()
    {
      var data = new List<DaneKuriera>() { TestDataFactory.DaneKuriera};
      var context = MockMainteiner.PobierzContextKurierow(data);

      DaneKuriera pobraneDaneKuriera = new KurierzyModel(context).PobierzKuriera(10);
      Assert.AreEqual(pobraneDaneKuriera, TestDataFactory.DaneKuriera);
      Assert.AreEqual(pobraneDaneKuriera.UserId, 10);

    }
    [TestMethod]
    public void PobierzNieistniejacegoKurieraTest()
    {
      var data = new List<DaneKuriera>() { TestDataFactory.DaneKuriera };
      var context = MockMainteiner.PobierzContextKurierow(data);

      DaneKuriera pobraneDaneKuriera = new KurierzyModel(context).PobierzKuriera(101);
      Assert.IsNull(pobraneDaneKuriera);
    }

    [TestMethod]
    public void PobierzListeKurierowTest()
    {
      var data = new List<DaneKuriera>() { TestDataFactory.DaneKuriera1, TestDataFactory.DaneKuriera2 };
      List<DaneKuriera> list = new KurierzyModel(MockMainteiner.PobierzContextKurierow(data)).PobierzListeKurierow();

      Assert.AreEqual(2, list.Count);
      Assert.AreEqual(list[0], TestDataFactory.DaneKuriera1);
      Assert.AreEqual(list[1], TestDataFactory.DaneKuriera2);
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


      var context = MockMainteiner.PobierzContextKurierow(new List<DaneKuriera>() { TestDataFactory.DaneKuriera1},
        paczki: new List<DanePaczki>() { TestDataFactory.Paczka1, TestDataFactory.Paczka2 });
      List<DanePaczki> paczki = (new KurierzyModel(context).PobierzListePaczekKuriera(3));
      Assert.AreEqual(1, paczki.Count);
      Assert.AreEqual(paczki[0], TestDataFactory.Paczka1);
    }

    [TestMethod]
    public void PobierzListePaczekKurieraBezPaczekTest()
    {
      var paczka1 = TestDataFactory.Paczka1;
      paczka1.Status.Kurier = null;
      var paczka2 = TestDataFactory.Paczka2;
      if (paczka2.Status != null) paczka2.Status.Kurier = null;
      var context = MockMainteiner.PobierzContextKurierow(new List<DaneKuriera>() { TestDataFactory.DaneKuriera1 },
        paczki: new List<DanePaczki>() { paczka1, paczka2 });
      List<DanePaczki> paczki = (new KurierzyModel(context).PobierzListePaczekKuriera(3));
      Assert.AreEqual(0, paczki.Count);
    }

    [TestMethod]
    public void PobierzSamochodKurieraTest()
    {
      var context = MockMainteiner.PobierzContextKurierow(new List<DaneKuriera>() { TestDataFactory.DaneKuriera1 }, samochody: new List<DaneSamochodu>() { TestDataFactory.Samochod });
      DaneSamochodu pobranySamochod = new KurierzyModel(context).PobierzSamochodKuriera(3);
      Assert.AreEqual(TestDataFactory.Samochod, pobranySamochod);
    }
    [TestMethod]
    public void PobierzSamochodKurieraBezSamochoduTest()
    {
      var context = MockMainteiner.PobierzContextKurierow(new List<DaneKuriera>() { TestDataFactory.DaneKuriera2 }, samochody: new List<DaneSamochodu>() { TestDataFactory.Samochod});
      DaneSamochodu pobranySamochod = new KurierzyModel(context).PobierzSamochodKuriera(4);
      Assert.IsNull(pobranySamochod);
    }




  }
}
