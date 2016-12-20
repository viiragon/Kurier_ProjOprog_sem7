using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kurier.Models.DTO.Uzytkownik;
using Kurier.Models.Context;
using Kurier.Models.DataAccess;

namespace KurierTest.Models
{
    [TestClass]
    public class IMUzytkownicyTest
    {
        [TestMethod]
        public void ZalogujDoCentraliTest()
        {
            DaneAuthUzytkownika uzytkownikPoprawny = new DaneAuthUzytkownika()
            {
                Login = "corzel",
                Haslo = "natak139e"

            };

            DaneAuthUzytkownika uzytkownikBlednyLogin = new DaneAuthUzytkownika()
            {
                Login = "corzelds",
                Haslo = "natak139e"

            };

            DaneAuthUzytkownika uzytkownikBledneHaslo = new DaneAuthUzytkownika()
            {
                Login = "corzel",
                Haslo = "123"

            };

            var context = new ApplicationContext();
            try
            {
                new UzytkownicyModel(context).ZalogujDoCentrali(uzytkownikPoprawny);
                new UzytkownicyModel(context).ZalogujDoCentrali(uzytkownikBlednyLogin);
                new UzytkownicyModel(context).ZalogujDoCentrali(uzytkownikBledneHaslo);
            }
            catch
            {
                throw new AssertFailedException();
            }
        }

        [TestMethod]
        public void ZalogujJakoKlientTest()
        {
        }

        [TestMethod]
        public void ZalogujJakoKurierTest()
        {
        }

        [TestMethod]
        public void ZarejestrujJakoKlientTest()
        {
        }

        [TestMethod]
        public void CzyIstniejeUzytkonikTest()
        {
        }
    }
}
