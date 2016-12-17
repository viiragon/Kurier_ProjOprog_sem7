using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kurier.Models.Context;
using Kurier.Models.DataAccess;
using Kurier.Models.DTO;
using Kurier.Models.DTO.Samochod;
using Kurier.Models.DTO.Uzytkownik;

namespace KurierTest.Models
{
    [TestClass]
    public class IMSamochodTest
    {
        [TestMethod]
        public void DodajSamochodTest()
        {
            DaneSamochodu samochod = new DaneSamochodu()
            {
                Id = 1,
                NumRejestracyjny = "WE123R",
                Stan = "Sprawny"
                
            };
            ApplicationContext context = MockMainteiner.PobierzContextSamochodow(new List<DaneSamochodu>() { });

            new SamochodyModel(context).DodajSamochod(samochod);
            DaneSamochodu pobranySamochod = context.Samochody.FirstOrDefault(p => p.Id == samochod.Id);
            Assert.AreEqual(pobranySamochod, samochod);
        }

        [TestMethod]
        public void PobierzListeSamochodowTest()
        {
            DaneSamochodu samochod1 = new DaneSamochodu()
            {
                Id = 1,
                NumRejestracyjny = "WE123R",
                Stan = "Sprawny"

            };

            DaneSamochodu samochod2 = new DaneSamochodu()
            {
                Id = 2,
                NumRejestracyjny = "PO123W",
                Stan = "Sprawny"

            };

            ApplicationContext context = MockMainteiner.PobierzContextSamochodow(new List<DaneSamochodu>() { samochod1, samochod2 });
            var list = new SamochodyModel(context).PobierzListeSamochodow();

            Assert.AreEqual(list[0], samochod1);
            Assert.AreEqual(list[1], samochod2);

        }

        [TestMethod]
        public void PobierzSamochodTest()
        {
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

            ApplicationContext context = MockMainteiner.PobierzContextSamochodow(new List<DaneSamochodu>() { samochod1, samochod2 });
            DaneSamochodu pobranySamochod = new SamochodyModel(context).PobierzSamochod(2);

            Assert.AreEqual(samochod2.Id, pobranySamochod.Id);
            Assert.AreEqual(samochod2.NumRejestracyjny, pobranySamochod.NumRejestracyjny);
            Assert.AreEqual(samochod2.Stan, pobranySamochod.Stan);
        }

        [TestMethod]
        public void PowiazKurieraISamochodTest()
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

            DaneSamochodu samochod1 = new DaneSamochodu()
            {
                Id = 1,
                NumRejestracyjny = "WE123R",
                Stan = "Sprawny"

            };

            var context = MockMainteiner.PobierzContextKurierow(new List<DaneKuriera>() { daneKuriera1 },
                samochody: new List<DaneSamochodu>() { samochod1 });
            new SamochodyModel(context).PowiazKurieraISamochod(samochod1.Id, daneKuriera1.UserId);
            var samochodKuriera = context.Kurierzy.FirstOrDefault(p => p.UserId == daneKuriera1.UserId).Samochod;

            Assert.IsNotNull(samochodKuriera);
            Assert.AreEqual(samochodKuriera, samochod1);

        }

        [TestMethod]
        public void UsunSamochodTest()
        {
            DaneSamochodu samochod1 = new DaneSamochodu()
            {
                Id = 1,
                NumRejestracyjny = "WE123R",
                Stan = "Sprawny"

            };

            ApplicationContext context = MockMainteiner.PobierzContextSamochodow(new List<DaneSamochodu>() { samochod1 });
            new SamochodyModel(context).UsunSamochod(samochod1.Id);
            var usuniety = context.Samochody.Find(samochod1.Id);
            Assert.IsNull(usuniety);
        }

        [TestMethod]
        public void WalidujDaneSamochoduTest()
        {
            DaneSamochodu samochodPoprawny = new DaneSamochodu()
            {
                Id = 1,
                NumRejestracyjny = "PO6478A",
                Stan = "Sprawny"

            };

            DaneSamochodu samochodBlednyNumerRej = new DaneSamochodu()
            {
                Id = 1,
                NumRejestracyjny = "PO@647&8A",
                Stan = "Sprawny"

            };

            DaneSamochodu samochodBrakNumeruRej = new DaneSamochodu()
            {
                Id = 1,
                NumRejestracyjny = "",
                Stan = "Sprawny"

            };

            DaneSamochodu samochodBlednyStan = new DaneSamochodu()
            {
                Id = 2,
                NumRejestracyjny = "POL74B6",
                Stan = "Sprawny11"

            };

            DaneSamochodu samochodBrakStanu = new DaneSamochodu()
            {
                Id = 1,
                NumRejestracyjny = "PO6478A",
                Stan = ""

            };

            ApplicationContext context = MockMainteiner.PobierzContextSamochodow(new List<DaneSamochodu>() { samochodPoprawny, samochodBlednyNumerRej, samochodBrakNumeruRej, samochodBlednyStan, samochodBrakStanu });
            Assert.IsTrue(new SamochodyModel(context).WalidujDaneSamochodu(samochodPoprawny));
            Assert.IsFalse(new SamochodyModel(context).WalidujDaneSamochodu(samochodBlednyNumerRej));
            Assert.IsFalse(new SamochodyModel(context).WalidujDaneSamochodu(samochodBrakNumeruRej));
            Assert.IsFalse(new SamochodyModel(context).WalidujDaneSamochodu(samochodBlednyStan));
            Assert.IsFalse(new SamochodyModel(context).WalidujDaneSamochodu(samochodBrakStanu));
        }
    }
}

    
    