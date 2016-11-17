using System.Linq;
using Kurier.Models.Context;
using Kurier.Models.DataAccess;
using Kurier.Models.DTO;
using Kurier.Models.DTO.Uzytkownik;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KurierTest.Models
{
  [TestClass]
  public class IMKurierTest
  {
    [TestMethod]
    public void DodajKurieraTest()
    {
      DaneKuriera pobraneDaneKuriera;

      DaneKuriera daneKuriera = new DaneKuriera()
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
        NumerPracowanika = 199999
      };

      new KurierzyModel().DodajKuriera(daneKuriera);

      using (var db = new ApplicationContext())
      {
        pobraneDaneKuriera = db.Kurierzy.FirstOrDefault(
          p => p.Imie == "Maciej"
        && p.Nazwisko == "Kowalski"
        && p.Adres.KodPocztowy == "09-201"
        && p.Adres.Miasto == "Sierpc"
          && p.Adres.NumerMieszkania == "2"
          && p.Adres.Ulica == "Poniatowskiego"
          && p.NumerPracowanika == 199999
        );
      }

      Assert.IsNotNull(pobraneDaneKuriera);
      using (var db = new ApplicationContext())
      {
        db.Kurierzy.Remove(pobraneDaneKuriera);
        db.SaveChanges();
      }
    }

    //void DodajKuriera(DaneKuriera kurier);
    //DaneKuriera PobierzKuriera(int id);
    //List<DaneKuriera> PobierzListeKurierow();
    //List<DanePaczki> PobierzListePaczekKuriera(int idKuriera);
    //DaneSamochodu PobierzSamochodKuriera(int id);
    //bool WalidujDaneKuriera(DaneKuriera kurier);
  }
}
